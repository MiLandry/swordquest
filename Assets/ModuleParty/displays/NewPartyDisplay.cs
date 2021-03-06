﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//used to show the widget for selecting a new party
public class NewPartyDisplay : MonoBehaviour
{

    public string PartyName;
    public Sprite Icon;
    public List<GCharacter> PartyMembers;

    // public GameObject IconDisplay;
    // public GameObject TextDisplay;

    private void Start()
    {
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = PartyName;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = Icon;


        // icon = party.theSprite;
        // name.text = party.partyName;
    }

    public void OnPartyClick()
    {
        Debug.Log("Initial party selected: " + PartyName);
        PartyService partyService = Object.FindObjectOfType<PartyService>();
        partyService.PartyName = PartyName;
        partyService.PartyMembers = PartyMembers;

        foreach (GCharacter gCharacter in PartyMembers)
        {
          gCharacter.Initialize();
        }

// todo, Initialize the party members
        
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Strategic");

    }


}
