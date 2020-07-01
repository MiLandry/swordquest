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
    public GameObject GCharacterInformationDisplay;

    private void addHero(GCharacter_SO hero)
    {
        GameObject container = this.transform.Find("Hero container").gameObject;
        GridLayoutGroup grid = container.GetComponent(typeof(GridLayoutGroup)) as GridLayoutGroup;
        GameObject display = Instantiate(GCharacterInformationDisplay, new Vector3(0, 0, 0), Quaternion.identity);

        //display.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.name;
        //display.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + hero.hp.ToString();
        //display.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.gClass.name;
        //display.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = hero.icon;

        //display.GetComponent<UnityEngine.UI.Text>().text = hero.name;


        display.transform.SetParent(grid.transform);
        // get reference to container


        // add a game object to container

    }


    private void Start()
    {
        // PartyService partyService = Object.FindObjectOfType<PartyService>();
        // // party = partyService.Party;

        // //icon.sprite = party.theSprite;
        // partyName.text = party.partyName;
        // foreach (GCharacter hero in party.gCharacters) // Loop through List with foreach
        // {
        //     addHero(hero);

        // }


    }




}
