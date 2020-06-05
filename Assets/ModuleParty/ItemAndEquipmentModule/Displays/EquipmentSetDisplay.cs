using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSetDisplay : MonoBehaviour
{
    private GCharacter_SO gCharacter;
    public GameObject equipmentDisplay;

    // maybe change to awake??
    private void Start()
    {
        if (gCharacter == null)
        {
            // If not injected with data, this will look up the 'first' character
            // member of the party
            PartyService partyService = Object.FindObjectOfType<PartyService>();

            gCharacter = partyService.Party.gCharacters[0];

        }

        foreach (Equipment equipment in gCharacter.equipmentSet)
        {
            GameObject display = Instantiate(equipmentDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject layout = this.transform.GetChild(0).gameObject;
            display.transform.SetParent(layout.transform);
            display.GetComponent<EquipmentDisplay>().Equipment = equipment;
        }


        //this.transform.Find("MainHandDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = gCharacter.mainHand.name;
        //this.transform.Find("MainHandDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = gCharacter.mainHand.icon;

        //this.transform.Find("OffHandDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = gCharacter.offHand.name;
        //this.transform.Find("OffHandDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = gCharacter.offHand.icon;

        //this.transform.Find("BodyDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = gCharacter.body.name;
        //this.transform.Find("BodyDisplay").gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = gCharacter.body.icon;

    }


    //public void OnMainHandClick()
    //{
    //    // need reference to 'slot'
    //    //open the party equipment display
    //    PartyService partyService = Object.FindObjectOfType<PartyService>();
    //    partyService.ToggleInventory();
    //    // make sure it only show mainhand equipment
    //    //after one is chosen. Update the character equipment.


    //}
}