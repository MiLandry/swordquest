using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GCharacterDisplay : MonoBehaviour
{
    public GCharacter GCharacter;


    private void Start()
    {
        // if empty, use the "first" character in the party
        if (String.IsNullOrEmpty(GCharacter.Name))
        {
        PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
        GCharacter = partyService.PartyMembers[0];
        }

        Debug.Log("Creating GCharactir Information Display : " + GCharacter.Name);
        Render();
    }

    public void Render()
    {
        Debug.Log("drawing an GCharacterDisplay");
        this.transform.Find("Icon").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = GCharacter.Icon;
        this.transform.Find("Name").gameObject.GetComponent<UnityEngine.UI.Text>().text = "Name: " + GCharacter.Name;
        this.transform.Find("Hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + GCharacter.CurrentHp.ToString();
        this.transform.Find("GClass").gameObject.GetComponent<UnityEngine.UI.Text>().text = "Class: " + GCharacter.gClass.Name;
    }

    public void OnClick()
    {
        Debug.Log("Character info display clicked");
        //Open character editor for this character

        PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
        partyService.EditCharacter(GCharacter.Id);

    }

}