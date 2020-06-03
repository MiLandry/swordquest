using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is probably going to become the PartyService. It will be singleton service.
//and stateful. Its loaded before every run.
//reference this by PartyService partyService = Object.FindObjectOfType<PartyService>();
public class PartyService : Singleton<PartyService>
{
    public Party_SO party
    {
        get; set;
    }

    override protected void Awake()
    {
        Debug.Log("Creating PartyService...");
        base.Awake();

        if (party == null)
        {
            Party_SO testParty = Resources.Load<Party_SO>("TestData/TestParty");
            party = testParty;
            Debug.Log("Loading test party for gameplay");

        }
    }
}
