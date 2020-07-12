using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDisplay : MonoBehaviour
{
    public Enemy Enemy;
    public void Render()
    {
        Debug.Log("drawing an EnemyDisplay");
        this.transform.Find("Text").gameObject.GetComponent<UnityEngine.UI.Text>().text = Enemy.Name;
        this.transform.Find("Icon").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Enemy.Icon;
    }
}
