using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnEquipmentClickedArgs
{
    public OnEquipmentClickedArgs(Equipment equipment) { Equipment = equipment; }
    public Equipment Equipment { get; }
}

public class EquipmentDisplay : MonoBehaviour
{
    public Equipment Equipment
    { get; set; }


    private void Start()
    {
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = Equipment.name;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = Equipment.icon;

    }


    public delegate void OnEquipmentClickedHandler(object sender, OnEquipmentClickedArgs e);

    public static event OnEquipmentClickedHandler OnEquipmentClicked;

    public void OnInventoryItemClicked()
    {
        Debug.Log("Event EquipmentClicked Raised");
        Debug.Log("equipment: " + Equipment.name);
        OnEquipmentClicked?.Invoke(this, new OnEquipmentClickedArgs(Equipment));

    }
}

