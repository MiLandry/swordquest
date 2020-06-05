using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIconDisplay : MonoBehaviour
{
    private GCharacter_SO gCharacter;

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



        this.transform.Find("Icon").gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = gCharacter.icon;

    }
}
