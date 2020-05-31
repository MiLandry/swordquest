using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyManager : MonoBehaviour
{
    public static Party_SO party
    {
        get; set;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (party == null)
        {
            Party_SO testParty = Resources.Load<Party_SO>("TestData/TestParty");
            party = testParty;

        }


    }
}
