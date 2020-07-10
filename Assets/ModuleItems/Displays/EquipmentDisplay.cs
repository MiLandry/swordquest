using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnEquipmentClickedArgs
{
    public OnEquipmentClickedArgs(Equipment equipment, int index) { Equipment = equipment; Index = index; }
    public Equipment Equipment { get; }
    public int Index { get; }
}

public class EquipmentDisplay : MonoBehaviour
{
    public Equipment Equipment
    { get; set; }

    public int Index {get; set; }


    private void Start()
    {
        if (Equipment == null)
        {
            //load a herring as a default
            // Equipment =
            //     Resources.Load<Equipment>("TestData/Herring");
        }

        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = Equipment.Name;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = Equipment.Icon;

    }


    public delegate void OnEquipmentClickedHandler(object sender, OnEquipmentClickedArgs e);

    public static event OnEquipmentClickedHandler OnEquipmentClicked;

    // public void OnInventoryItemClicked()
    // {
    //     Debug.Log("Event EquipmentClicked Raised" + "equipment: " + Equipment.name);
    //     OnEquipmentClicked?.Invoke(this, new OnEquipmentClickedArgs(Equipment, Index));
    // }
}

