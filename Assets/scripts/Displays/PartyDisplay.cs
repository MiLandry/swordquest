using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyDisplay : MonoBehaviour
{

    private Party_SO party;
    public Text partyName;

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    //it should already be bundled with the prefab
    public GameObject heroInformationDisplay;

    private void addHero(Hero_SO hero)
    {
        GameObject container = this.transform.Find("Hero container").gameObject;
        GridLayoutGroup grid = container.GetComponent(typeof(GridLayoutGroup)) as GridLayoutGroup;
        GameObject display = Instantiate(heroInformationDisplay, new Vector3(0, 0, 0), Quaternion.identity);

        display.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.name;
        display.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + hero.hp.ToString();
        display.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.gClass.name;
        display.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = hero.icon;

        //display.GetComponent<UnityEngine.UI.Text>().text = hero.name;


        display.transform.SetParent(grid.transform);
        // get reference to container


        // add a game object to container

    }


    private void Start()
    {
        party = PartyManager.party;

        //icon.sprite = party.theSprite;
        partyName.text = party.partyName;
        foreach (Hero_SO hero in party.heroes) // Loop through List with foreach
        {
            addHero(hero);

        }


    }




}
