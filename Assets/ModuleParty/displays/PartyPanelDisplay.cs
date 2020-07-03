using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//gets used to show the high level summary of the party during the strategic displays
public class PartyPanelDisplay : MonoBehaviour
{

    // public Party Party;

    void Start()
    {

        PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
                Debug.Log("starting party panel display for the party: " +  partyService.PartyName);

        this.transform.gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = partyService.PartyName;
        

    }

    // private void addHero(GCharacter_SO hero)
    // {
    //     GameObject container = this.transform.Find("Hero container").gameObject;
    //     GridLayoutGroup grid = container.GetComponent(typeof(GridLayoutGroup)) as GridLayoutGroup;
    //     GameObject display = Instantiate(GCharacterInformationDisplay, new Vector3(0, 0, 0), Quaternion.identity);

    //     //display.transform.Find("Hero name").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.name;
    //     //display.transform.Find("hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + hero.hp.ToString();
    //     //display.transform.Find("gclass").gameObject.GetComponent<UnityEngine.UI.Text>().text = hero.gClass.name;
    //     //display.transform.Find("Character art").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = hero.icon;

    //     //display.GetComponent<UnityEngine.UI.Text>().text = hero.name;

    //     display.transform.SetParent(grid.transform);
    //     // get reference to container


    //     // add a game object to container

    // }
}
