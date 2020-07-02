using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//used to show the widget for selecting a new party
public class NewPartyDisplay : MonoBehaviour
{

    public Party party;

    // public GameObject IconDisplay;
    // public GameObject TextDisplay;

    private void Start()
    {
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = party.partyName;
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Image>().sprite = party.icon;


        // icon = party.theSprite;
        // name.text = party.partyName;
    }

    public void OnPartyClick()
    {
        Debug.Log("Initial party selected: " + party.partyName);
        PartyService partyService = Object.FindObjectOfType<PartyService>();
        partyService.Party = party;
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Strategic");

    }


}
