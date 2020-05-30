﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyDisplay : MonoBehaviour
{
    public Party_SO party;

    public Text partyName;

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject heroInformationDisplay;

    public void addHero(Hero_SO hero)
    {
        Debug.Log(this);
        Debug.Log(hero);
        Debug.Log(heroInformationDisplay);
        GameObject container = this.transform.Find("Hero container").gameObject;
        Debug.Log(container);
        GridLayoutGroup grid = container.GetComponent(typeof(GridLayoutGroup)) as GridLayoutGroup;
        GameObject display = Instantiate(heroInformationDisplay, new Vector3(0, 0, 0), Quaternion.identity);

        //this.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.name;
        //this.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "42";

        //display.GetComponent<UnityEngine.UI.Text>().text = hero.name;


        display.transform.SetParent(grid.transform);
        // get reference to container


        // add a game object to container

    }


    private void Start()
    {

        //icon.sprite = party.theSprite;
        Debug.Log(party.partyName);
        partyName.text = party.partyName;
        foreach (Hero_SO hero in party.heroes) // Loop through List with foreach
        {
            //Console.WriteLine(item);
            //Debug.Log(hero);
            addHero(hero);
            //Instantiate(heroInformationDisplay, new Vector3(0, 0, 0), Quaternion.identity);
        }

        // loop through party.heroes, create a game object or prefab for Each.
        //party.heroes

    }

    //public void OnPartyClick()
    //{
    //    Debug.Log("hello world");
    //    // do one of the following
    //    // engage the state manager  or dispatch an event that initializes the current party.

    //}


}