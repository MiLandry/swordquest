using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EquipmentSlotSetDisplay : MonoBehaviour
{
    
    public GameObject EquipmentSlotDisplay;
    public List<EquipmentSlot> EquipmentSlotSet;
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
        Debug.Log("start()ing EquipemntSetDisplay");
        PartyService partyService = Object.FindObjectOfType<PartyService>();
        // if (!EquipmentSet.Any())
        // {
        //     // for now, this fetches the first party member equipment
        //     EquipmentSet = partyService.PartyMembers[0].EquipmentSet;
        // }

                if (!EquipmentSlotSet.Any())
        {
            // for now, this fetches the first party member equipment
            EquipmentSlotSet = partyService.PartyMembers[0].EquipmentSlotSet;
        }

        //    .OrderByDescending(e => e.sortRank).ToList();
        //    .OrderByDescending(e => e.sortRank);
        render();


    }


    private void render()
    {
        Debug.Log("render()ing EquipemntSetDisplay");

        //Layout prefab
        GameObject layout = this.transform.GetChild(0).gameObject;
        //delete all equipmentDisplay game object children in the layout
        foreach( GameObject go in renderedEquipmentDisplays)
        {
            Destroy(go);
        }




        int i = 0;
        foreach (EquipmentSlot slot in EquipmentSlotSet)
        {
            GameObject display = Instantiate(EquipmentSlotDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            display.transform.SetParent(layout.transform);
            display.GetComponent<EquipmentSlotDisplay>().EquipmentSlot = slot;
            display.GetComponent<EquipmentSlotDisplay>().Index = i;
            display.GetComponent<EquipmentSlotDisplay>().Render();
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