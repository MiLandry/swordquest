using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to show a placeholder icon if there is nothing equipped.


// public class OnEquipmentClickedArgs
// {
//     public OnEquipmentClickedArgs(Equipment equipment, int index) { Equipment = equipment; Index = index; }
//     public Equipment Equipment { get; }
//     public int Index { get; }
// }



public class EquipmentSlotDisplay : MonoBehaviour
{
    public EquipmentSlot EquipmentSlot
    { get; set; }

    public int Index {get; set; }


    private void Start()
    {
        Sprite icon;
        string slotName;
        if (EquipmentSlot == null)
        {
            icon = Resources.Load<Sprite>("Icons/Elixir_4");
            slotName = "";
        }
        else
        {
            icon =  EquipmentSlot.Equipment.icon;
            slotName = EquipmentSlot.Equipment.name;


        }
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = slotName;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = icon;

    }


    // public delegate void OnEquipmentClickedHandler(object sender, OnEquipmentClickedArgs e);

    // public static event OnEquipmentClickedHandler OnEquipmentClicked;

    // public void OnInventoryItemClicked()
    // {
    //     Debug.Log("Event EquipmentClicked Raised" + "equipment: " + Equipment.name);
    //     OnEquipmentClicked?.Invoke(this, new OnEquipmentClickedArgs(Equipment, Index));

    // }
}

