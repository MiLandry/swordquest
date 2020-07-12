using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GCharacterInformationDisplay : MonoBehaviour
{
    public GCharacter GCharacter;

    //public Image icon;

    // maybe change to awake??
    private void Start()
    {

        // if empty, use the "first" character in the party
        if (String.IsNullOrEmpty(GCharacter.name))
        {
            PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
            GCharacter = partyService.PartyMembers[0];
        }

        Debug.Log("Creating GCharactir Information Display : " + GCharacter.name);
        this.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = GCharacter.name;
        this.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + GCharacter.currentHp.ToString();
        this.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = GCharacter.gClass.name;
        this.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = GCharacter.icon;

    }

    public void OnClick()
    {
        Debug.Log("Character info display clicked");
        //Open character editor for this character

         PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
        partyService.EditCharacter(GCharacter.Id);

    }

}