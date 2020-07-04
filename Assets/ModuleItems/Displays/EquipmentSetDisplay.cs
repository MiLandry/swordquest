using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EquipmentSetDisplay : MonoBehaviour
{
    
    public GameObject EquipmentDisplay;
    public List<Equipment> EquipmentSet;
    private List<GameObject> renderedEquipmentDisplays = new List<GameObject>();

    private void Awake()
    {
        OnEquipmentEquippedEvent.OnEquipmentEquipped += SomeFunc;
    }

    private void OnDestroy()
    {
        OnEquipmentEquippedEvent.OnEquipmentEquipped -= SomeFunc;
    }


    private void Start()
    {
        PartyService partyService = Object.FindObjectOfType<PartyService>();
        if (!EquipmentSet.Any())
        {
            // for now, this fetches the first party member equipment
            EquipmentSet = partyService.PartyMembers[0].EquipmentSet;
        }

        //    .OrderByDescending(e => e.sortRank).ToList();
        //    .OrderByDescending(e => e.sortRank);
        render();


    }


    private void render()
    {
        GameObject layout = this.transform.GetChild(0).gameObject;
        //delete all equipmentDisplay game object children in the layout
        foreach( GameObject go in renderedEquipmentDisplays)
        {
            Destroy(go);
        }


        int i = 0;
        foreach (Equipment equipment in EquipmentSet)
        {
            GameObject display = Instantiate(EquipmentDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            display.transform.SetParent(layout.transform);
            display.GetComponent<EquipmentDisplay>().Equipment = equipment;
            display.GetComponent<EquipmentDisplay>().Index = i;
            renderedEquipmentDisplays.Add(display);
            i++;
        }
    }


     private void SomeFunc(object sender, OnEquipmentEquippedArgs e)
     {
         Debug.Log("equipmentsetdisplay callback for OnEquipmentEquipped");
         render();
         
     }


}