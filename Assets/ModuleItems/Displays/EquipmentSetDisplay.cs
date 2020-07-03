using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EquipmentSetDisplay : MonoBehaviour
{
    
    public GameObject equipmentDisplay;
    public List<Equipment> EquipmentSet;

    // maybe change to awake??
    private void Start()
    {
        PartyService partyService = Object.FindObjectOfType<PartyService>();
        if (!EquipmentSet.Any());
        {
            // for now, this fetches the first party member equipment


            EquipmentSet = partyService.PartyMembers[0].EquipmentSet;

        }


        //    .OrderByDescending(e => e.sortRank).ToList();
        //    .OrderByDescending(e => e.sortRank);
        int i = 0;
        foreach (Equipment equipment in EquipmentSet)
        {
            GameObject display = Instantiate(equipmentDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject layout = this.transform.GetChild(0).gameObject;
            display.transform.SetParent(layout.transform);
            display.GetComponent<EquipmentDisplay>().Equipment = equipment;
            display.GetComponent<EquipmentDisplay>().Index = i;
            i++;
        }

    }


    //TODO I have to destroy and re instantiate whenever the EquipmentSet changes;

    // private void Update()
    // {
    //     Debug.Log("updating Equipment set display");
    // }


}