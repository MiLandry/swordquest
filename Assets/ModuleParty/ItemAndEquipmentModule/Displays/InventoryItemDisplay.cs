using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnItemSelectedArgs
{
    public OnItemSelectedArgs(string text) { Text = text; }
    public string Text { get; } // readonly
}

public class InventoryItemDisplay : MonoBehaviour
{
    //TODO factor this event out of this class
    // Declare the delegate (if using non-generic pattern).
    public delegate void OnItemSelectedHandler(object sender, OnItemSelectedArgs e);

    // Declare the event.
    public static event OnItemSelectedHandler OnItemSelected;

    public void OnInventoryItemClicked()
    {
        Debug.Log("Item wuz clicked");
        // Raise the event in a thread-safe manner using the ?. operator.
        OnItemSelected?.Invoke(this, new OnItemSelectedArgs("Hello"));

    }
}
