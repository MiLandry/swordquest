using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnEquipmentEquippedEvent
{
    public delegate void OnEquipmentEquippedHandler(object sender, OnEquipmentEquippedArgs e);
    // this is the event
    public static event OnEquipmentEquippedHandler OnEquipmentEquipped;

    public static void Raise(object sender, OnEquipmentEquippedArgs e)
    {
        Debug.Log("Raising OnEquipmentEquipped event...");
        OnEquipmentEquipped?.Invoke(sender, e);
    }


}




            // usage
            // OnEquipmentEquipped?.Invoke(this, new OnOnEquipmentEquippedArgs(e.Item as Equipment));