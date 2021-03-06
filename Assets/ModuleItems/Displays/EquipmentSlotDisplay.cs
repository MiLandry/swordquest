﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to show a placeholder icon if there is nothing equipped.


public class OnEquipmentClickedArgs
{
    public OnEquipmentClickedArgs(EquipmentSlot equipment, int index) { EquipmentSlot = equipment; Index = index; }
    public EquipmentSlot EquipmentSlot { get; }
    public int Index { get; }
}



public class EquipmentSlotDisplay : MonoBehaviour
{
    public EquipmentSlot EquipmentSlot
    { get; set; }

    public int Index {get; set; }


    private void Start()
    {

        if (EquipmentSlot == null)
        {
            Debug.Log("Getting default equipmentslot");
            PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
            EquipmentSlot = partyService.PartyMembers[0].EquipmentSlotSet[0];


        }




    }

    public void Render()
    {
        Sprite icon = EquipmentSlot.GetIcon();
        string slotName;


        Equipment equipment = EquipmentSlot.Equipment;
        if ( equipment == null)
        {

            slotName = "";
        }
        else
        {
            slotName = EquipmentSlot.Equipment.Name;
        }
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = slotName;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = icon;

    }


    public delegate void OnEquipmentClickedHandler(object sender, OnEquipmentClickedArgs e);

    public static event OnEquipmentClickedHandler OnEquipmentClicked;

    public void OnInventoryItemClicked()
    {
        Debug.Log("Event EquipmentClicked Raised" + "equipment: " + EquipmentSlot.GetName());
        OnEquipmentClicked?.Invoke(this, new OnEquipmentClickedArgs(EquipmentSlot, Index));

    }
}

