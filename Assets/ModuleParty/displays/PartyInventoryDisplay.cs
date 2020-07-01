﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyInventoryDisplay : MonoBehaviour
{
    private List<Item_SO> items;
    public GameObject itemDisplay;

    private void Start()
    {
        if (items == null)
        {
            // If not injected with data, this will look up the 'first' character
            // member of the party
            PartyService partyService = Object.FindObjectOfType<PartyService>();

            items = partyService.Inventory;
            UnityEngine.UI.GridLayoutGroup layoutGroup = this.GetComponent<UnityEngine.UI.GridLayoutGroup>();

            foreach (Item_SO item in items) // Loop through List with foreach
            {
                GameObject display = Instantiate(itemDisplay, new Vector3(0, 0, 0), Quaternion.identity);
                display.transform.SetParent(layoutGroup.transform, false);
                display.transform.Find("ItemName").GetComponent<UnityEngine.UI.Text>().text = item.name;
                display.transform.Find("Icon").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = item.icon;
                display.GetComponent<InventoryItemDisplay>().Item = item;
            }

        }
    }
}
