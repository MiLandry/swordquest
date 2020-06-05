using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is probably going to become the PartyService. It will be singleton service.
//and stateful. Its loaded before every run.
//reference this by PartyService partyService = Object.FindObjectOfType<PartyService>();
public class PartyService : Singleton<PartyService>
{
  public Party_SO Party
  {
    get; set;
  }

  override protected void Awake()
  {
    Debug.Log("Creating PartyService...");
    base.Awake();

    //load test data
    if (Party == null)
    {
      Party_SO testParty = Resources.Load<Party_SO>("TestData/TestParty");
      Party = testParty;
      Debug.Log("Loading test party for gameplay");

    }

    //subscribe to stuff
    InventoryItemDisplay.OnItemSelected += AddItemToPartyInventory;
    EquipmentDisplay.OnEquipmentClicked += ChangeEquipment;


  }

  override protected void OnDestroy()
  {
    InventoryItemDisplay.OnItemSelected -= AddItemToPartyInventory;
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
    //throw new NotImplementedException();
  }

  private void UpdateCharacterEquipment(GCharacter_SO gCharacter, Item_SO newItem, Item_SO itemToDisplace)
  {
    //GCharacter_SO oldChar = Party.gCharacters.Find(gCharacter);

  }

  public void EquipItem(GCharacter_SO gCharacter, Item_SO newItem)
  {
    // update the character equipement set , add the existing equipemnt
    //to the party inventory, and remove the equipment from the party inventory

  }



  private void AddItemToPartyInventory(object sender, OnItemSelectedArgs e)
  {
    Debug.Log("adding new Item" + e.Text);
    //Party.inventory.Add(e.Item);
    // wait what I doing
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
      //   inventoryPanel.transform.GetChild(0).gameObject.SetActive(!gameObject.activeInHierarchy);

    }
    else
    {
      Debug.LogWarning("trying to open the inventory panel but none is present in the scene.");
    }
  }
}
