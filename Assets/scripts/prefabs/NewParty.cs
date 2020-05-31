using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewParty : MonoBehaviour
{
    //public PartyReference partyReference; not needed we are hardcoded
    public Party_SO party;


    public Image icon;
    public new Text name;


    private void Start()
    {
        icon.sprite = party.theSprite;
        name.text = party.name;
    }

    public void OnPartyClick()
    {
        Debug.Log("hello world");
        Debug.Log("party selected: " + party.partyName);
        PartyManager.party = party;
        UnityEngine.SceneManagement.SceneManager.LoadScene("StrategicMap");
        // load scene

        // do one of the following
        // engage the state manager  or dispatch an event that initializes the current party.
        // or overwrite the party data




    }


}
