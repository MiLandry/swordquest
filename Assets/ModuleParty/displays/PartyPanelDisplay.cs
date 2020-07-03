using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//gets used to show the high level summary of the party during the strategic displays
public class PartyPanelDisplay : MonoBehaviour
{
    public GameObject GCharacterInformationDisplay_GO;

    void Start()
    {

        PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
        Debug.Log("starting party panel display for the party: " +  partyService.PartyName);
        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = partyService.PartyName;

        foreach (GCharacter gCharacter in partyService.PartyMembers)
        {
           addHero(gCharacter);
        }
    }

    //logic for creating the individual hero displays
    private void addHero(GCharacter gCharacter)
    {
        GameObject container = this.transform.Find("GCharacter container").gameObject;
        GridLayoutGroup grid = container.GetComponent(typeof(GridLayoutGroup)) as GridLayoutGroup;
        GameObject display = Instantiate(GCharacterInformationDisplay_GO, new Vector3(0, 0, 0), Quaternion.identity);

        //display.transform.Find("gCharacter name").gameObject.GetComponent<UnityEngine.UI.Text>().text = gCharacter.name;
        //display.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + gCharacter.hp.ToString();
        //display.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = gCharacter.gClass.name;
        //display.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = gCharacter.icon;

        //display.GetComponent<UnityEngine.UI.Text>().text = hero.name;

        display.transform.SetParent(grid.transform);
        // get reference to container


        // add a game object to container

    }
}
