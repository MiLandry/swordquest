using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnEquipmentEquippedEvent
{
    //this is the delegate
    public delegate void OnEquipmentEquippedHandler(object sender, OnEquipmentEquippedArgs e);

    // this is the event
    public static event OnEquipmentEquippedHandler OnEquipmentEquipped;

    public static void Raise(object sender, OnEquipmentEquippedArgs e)
    {
        Debug.Log("Raising OnEquipmentEquipped event...");
        OnEquipmentEquipped?.Invoke(sender, e);
    }

}
