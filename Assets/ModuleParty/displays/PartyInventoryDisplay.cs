﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PartyInventoryDisplay : MonoBehaviour
{
    private List<Item> items;
    public GameObject itemDisplay;
    UnityEngine.UI.GridLayoutGroup layoutGroup;

    private void Start()
    {
        if (items == null || !items.Any())
        {
            // If not injected with data, this will look up the 'first' character
            // member of the party
            PartyService partyService = Object.FindObjectOfType<PartyService>();

            items = partyService.Inventory;
            layoutGroup = this.GetComponent<UnityEngine.UI.GridLayoutGroup>();
            Render();



        }
    }

    public void Render()
    {
    foreach (Item item in items) // Loop through List with foreach
    {
    GameObject display = Instantiate(itemDisplay, new Vector3(0, 0, 0), Quaternion.identity);
    display.transform.SetParent(layoutGroup.transform, false);
    display.transform.Find("ItemName").GetComponent<UnityEngine.UI.Text>().text = item.Name;
    display.transform.Find("Icon").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = item.Icon;
    display.GetComponent<InventoryItemDisplay>().Item = item;
    }

    }
}
