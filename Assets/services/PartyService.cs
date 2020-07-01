using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Its loaded before every run.
//reference this by PartyService partyService = Object.FindObjectOfType<PartyService>();
public class PartyService : Singleton<PartyService>
{
    // public Party party
    // {
    //     get; set;
    // }



    public GCharacter_SO GCharacter;

    public List<Equipment> EquipmentSet;

    public int IndexOfEquipmentBeingChanged;

    public List<Item_SO> Inventory;



    public Party_SO Party
    {
        get; set;
    }

    // public GCharacter_SO CharacterCurrentlyEdited
    // {
    //     get; set;
    // }



    override protected void Awake()
    {
        Debug.Log("Creating PartyService...");
        base.Awake();

        //load test data
        // if (Party == null)
        // {
        //     Party_SO testParty = Resources.Load<Party_SO>("TestData/TestParty");
        //     // probably need to copy over test data into 'game data'????
        //     Party = testParty;
        //     //CharacterCurrentlyEdited = Party.gCharacters[0];
        //     Debug.Log("Loading test party for gameplay");

        // }

        //subscribe to stuff
        InventoryItemDisplay.OnItemSelected += EquipItem;
        EquipmentDisplay.OnEquipmentClicked += ChangeEquipment;


    }
    void Start()
    {
        if (GCharacter == null)
        {
            DefaultData defaultData = GameObject.Find("DefaultData").GetComponent<DefaultData>();
            GCharacter = defaultData.GCharacter;

        }


        if (!EquipmentSet.Any());
        {

            DefaultData defaultData = GameObject.Find("DefaultData").GetComponent<DefaultData>();
            EquipmentSet = defaultData.EquipmentSet;

        }

        if (!Inventory.Any()) ;
        {

            DefaultData defaultData = GameObject.Find("DefaultData").GetComponent<DefaultData>();
            Inventory = defaultData.Inventory;

        }
    }


    override protected void OnDestroy()
    {
        InventoryItemDisplay.OnItemSelected -= EquipItem;
        EquipmentDisplay.OnEquipmentClicked -= ChangeEquipment;
    }

    // end of boilerplate

    /// <summary>
    /// Opens a party inventory panel, and filters for the type of equipment that
    /// can go into the requested slot.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ChangeEquipment(object sender, OnEquipmentClickedArgs e)
    {
        //open party inventory panel
        ToggleInventory();
        IndexOfEquipmentBeingChanged = e.Index;

    }


    private void EquipItem(object sender, OnItemSelectedArgs e)
    {
        ToggleInventory();

        Debug.Log(" Equipping item..." + e.Item.name);
        if (e.Item is Equipment equipment) {
        EquipmentSet[IndexOfEquipmentBeingChanged] = equipment;
        }

        //EquipItem(CharacterCurrentlyEdited, (Equipment)e.Item, 0);
    }



    public void EquipItem(GCharacter_SO gCharacter, Equipment newItem, int indexOfEquipmentSet)
    {
        //GCharacter_SO oldCharacter = Party.gCharacters.Find(gCharacter);
        //GCharacter_SO character = Party.gCharacters.Find(c => c.Equals(gCharacter));



        // character.equipmentSet[indexOfEquipmentSet] = newItem;
        // update the character equipement set , add the existing equipemnt
        //to the party inventory, and remove the equipment from the party inventory

    }



    private void AddItemToPartyInventory(object sender, OnItemSelectedArgs e)
    {

    }

    /// <summary>
    /// "opens" the inventory panel.How it works.It finds the inventory game wrapper by
    /// tag and enables its child component, the canvas for the panel.
    /// </summary>
    public void ToggleInventory()
    {

        if (GameObject.FindGameObjectsWithTag("InventoryPanel").Length > 0)
        {
            GameObject inventoryPanel = GameObject.FindGameObjectsWithTag("InventoryPanel")[0];
            GameObject inventoryPanelCanvas = inventoryPanel.transform.GetChild(0).gameObject;
            inventoryPanelCanvas.SetActive(!inventoryPanelCanvas.activeInHierarchy);

        }
        else
        {
            Debug.LogWarning("trying to open the inventory panel but none is present in the scene.");
        }
    }
}
