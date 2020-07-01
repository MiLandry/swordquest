using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDisplay : MonoBehaviour
{

    public GCharacter_SO Gcharacter;

    private void Start()
    {
        if (Gcharacter == null)
        {
            /*
              //It will check against the Party / character service for a default

              //it will ALWAYS load testconan

              It has to display a character that can be changed around

              //check the party service

              // if party service is empty,
              // it will find the Default prehab and use that

            */


            PartyService partyService = Object.FindObjectOfType<PartyService>();

            Gcharacter = partyService.GCharacter;

        }
        
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = Gcharacter.name;





    }
}
