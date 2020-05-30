using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroInformationDisplay : MonoBehaviour
{
    public Party_SO party;

    //public Image icon;
    public new Text name;


    private void Start()
    {
        //icon.sprite = party.theSprite;
        name.text = party.name;
    }

    //public void OnPartyClick()
    //{
    //    Debug.Log("hello world");
    //    // do one of the following
    //    // engage the state manager  or dispatch an event that initializes the current party.

    //}


}