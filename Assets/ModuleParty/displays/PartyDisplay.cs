using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//gets used to show the high level summary of the party during the strategic displays
public class PartyDisplay : MonoBehaviour
{

    public List<GCharacter> GCharacters;
    public GameObject ElementDisplay;
    private List<GameObject> renderedDisplays = new List<GameObject>();


    void Start()
    {

        PartyService partyService = UnityEngine.Object.FindObjectOfType<PartyService>();
        Debug.Log("Start() for PartyDisplay: " +  partyService.PartyName);
        GCharacters = partyService.PartyMembers;
        Render();


    }


    public void Render()
    {
        Debug.Log("render()ing PartyDisplay");
        //delete all equipmentDisplay game object children in the layout
        foreach( GameObject go in renderedDisplays)
        {
            Destroy(go);
        }

        Transform layoutGroup = this.transform.Find("Layout");
        int i = 0;
        foreach (GCharacter gChar in GCharacters)
        {
            GameObject display = Instantiate(ElementDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            display.transform.SetParent(layoutGroup);
            //TODO maybe use generic typing here
            display.GetComponent<GCharacterDisplay>().GCharacter = gChar;
            // display.GetComponent<EnemyDisplay>().Index = i;
            display.GetComponent<GCharacterDisplay>().Render();
            renderedDisplays.Add(display);
            i++;
        }
    }



}
