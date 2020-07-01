using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnItemSelectedArgs
{
    public OnItemSelectedArgs(Item_SO item) { Item = item; }
    public Item_SO Item { get; } // readonly
}

/// <summary>
/// This is for the generic inventory viewer.
/// </summary>
public class InventoryItemDisplay : MonoBehaviour
{

    public Item_SO Item
    {
        get; set;
    }
    //TODO factor this event out of this class
    // Declare the delegate (if using non-generic pattern).
    public delegate void OnItemSelectedHandler(object sender, OnItemSelectedArgs e);

    // Declare the event.  
    public static event OnItemSelectedHandler OnItemSelected;

    public void OnInventoryItemClicked()
    {
        Debug.Log("Inventory click event raised");
        // Raise the event in a thread-safe manner using the ?. operator.
        OnItemSelected?.Invoke(this, new OnItemSelectedArgs(Item));

    }
}
