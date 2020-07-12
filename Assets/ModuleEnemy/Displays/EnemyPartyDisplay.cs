using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//gets used to show the high level summary of the party during the strategic displays
public class EnemyPartyDisplay : MonoBehaviour
{
    public List<Enemy> Enemies;
    public GameObject ElementDisplay;
    private List<GameObject> renderedDisplays = new List<GameObject>();

    void Start()
    {

        EnemyService EnemyService = UnityEngine.Object.FindObjectOfType<EnemyService>();
        Debug.Log("starting Enemy party");
        Enemies = EnemyService.Enemies;
        Render();
    }

    public void Render()
    {
        Debug.Log("render()ing EquipemntSetDisplay");
        //delete all equipmentDisplay game object children in the layout
        foreach( GameObject go in renderedDisplays)
        {
            Destroy(go);
        }

        //Layout prefab
        GameObject layout = this.transform.GetChild(0).gameObject;
        int i = 0;
        foreach (Enemy enemy in Enemies)
        {
            GameObject display = Instantiate(ElementDisplay, new Vector3(0, 0, 0), Quaternion.identity);
            display.transform.SetParent(layout.transform);
            //TODO maybe use generic typing here
            display.GetComponent<EnemyDisplay>().Enemy = enemy;
            // display.GetComponent<EnemyDisplay>().Index = i;
            display.GetComponent<EnemyDisplay>().Render();
            renderedDisplays.Add(display);
            i++;
        }
    }
}
