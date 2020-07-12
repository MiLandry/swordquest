using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Its loaded before every run.
//reference this by...
//      PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
public class PartyService : Singleton<PartyService>
{
    Game game;

    public string PartyName;
    public List<GCharacter> PartyMembers;
    public int IndexOfEditedGCharacter;

    public string activeGCharacter;

    //only for testing/prototyping really
    public GCharacter GCharacter;
    public List<Equipment> EquipmentSet;
    public List<Item> Inventory;



    override protected void Awake()
    {
        Debug.Log("Creating PartyService...");
        base.Awake();
        game = UnityEngine.Object.FindObjectOfType<Game>();

        InventoryItemDisplay.OnItemSelected += EquipItem;
        EquipmentSlotDisplay.OnEquipmentClicked += ChangeEquipment;


    }
    void Start()
    {
        DefaultData defaultData = UnityEngine.Object.FindObjectOfType<DefaultData>();
        if (defaultData==null)
        {
            Debug.LogError(" Your default data prefab is broken and you are going to be sad.");
        }

        if (!PartyMembers.Any())
        {
            PartyMembers = defaultData.PartyMembers;
            PartyMembers[0].Initialize();

            // TODo make this a loop
        }
        IndexOfEditedGCharacter = 0;

        if (String.IsNullOrEmpty(PartyName))
        {
            PartyName = defaultData.PartyName;
        }


        // if (!EquipmentSet.Any());
        // {
        //     EquipmentSet = defaultData.EquipmentSet;
        // }

        if (!Inventory.Any())
        {
            foreach (var item in defaultData.Inventory)
            {

                switch (item)
                {
                    case Equipment_SO e:
                        Debug.Log("in equipment switch");
                            Inventory.Add(new Equipment(e));
                        break;
                    case Item_SO i:
                        Debug.Log("in item switch");
                        Inventory.Add(new Item(i));
                        break;
                    default:
                        throw new ArgumentException(
                        message: "item is not a recognized item type",
                        paramName: nameof(item));
                }

            //   var item = new Item(item_SO);
            //   Inventory.Add(item);
            }
        }
    }


    override protected void OnDestroy()
    {
        InventoryItemDisplay.OnItemSelected -= EquipItem;
        EquipmentSlotDisplay.OnEquipmentClicked -= ChangeEquipment;
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
        ToggleInventory();
    }


    private void EquipItem(object sender, OnItemSelectedArgs e)
    {
        ToggleInventory();
        var Gcharacter = PartyMembers[0];

        Debug.Log(" Equipping item...: " + e.Item.Name);
        Debug.Log("... onto Character: " + Gcharacter.name);
        if (e.Item is Equipment) {
            // GCharacter.Equip(e.Item as Equipment);
            PartyMembers[0].Equip(e.Item as Equipment);
            OnEquipmentEquippedEvent.Raise(this, new OnEquipmentEquippedArgs(e.Item as Equipment));
        }
    }



    public void EquipItem(GCharacter_SO gCharacter, Equipment newItem, int indexOfEquipmentSet)
    {
        // GCharacter_SO oldCharacter = Party.gCharacters.Find(gCharacter);
        // GCharacter_SO character = Party.gCharacters.Find(c => c.Equals(gCharacter));

        // character.equipmentSet[indexOfEquipmentSet] = newItem;
        // update the character equipement set , add the existing equipemnt;
        // to the party inventory, and remove the equipment from the party inventory;

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

    public void EditCharacter(string gCharacterId)
    {
        Debug.Log("editich character... ");
        Debug.Log("gCharacterId" + gCharacterId);
        activeGCharacter = gCharacterId;
        game = UnityEngine.Object.FindObjectOfType<Game>();
        game.LoadLevel("Character Menu");

    }
}
