using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GCharacterInformationDisplay : MonoBehaviour
{
    public GCharacter_SO gCharacter;

    //public Image icon;

    // maybe change to awake??
    private void Start()
    {
        if (gCharacter == null)
        {
            // If not injected with data, this will look up the 'first' character
            // member of the party
            PartyService partyService = Object.FindObjectOfType<PartyService>();

            gCharacter = partyService.party.gCharacters[0];

        }


        this.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = gCharacter.name;
        this.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + gCharacter.hp.ToString();
        this.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = gCharacter.gClass.name;
        this.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = gCharacter.icon;

    }




}