using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GCharacterDisplay : MonoBehaviour
{
    public GCharacter GCharacter;
    public void Render()
    {
        Debug.Log("drawing an GCharacterDisplay");
        this.transform.Find("Icon").gameObject.GetComponent<UnityEngine.UI.Image>().sprite = GCharacter.Icon;
        this.transform.Find("Name").gameObject.GetComponent<UnityEngine.UI.Text>().text = GCharacter.Name;
        this.transform.Find("Hp").gameObject.GetComponent<UnityEngine.UI.Text>().text = "HP: " + GCharacter.CurrentHp.ToString();
        this.transform.Find("GClass").gameObject.GetComponent<UnityEngine.UI.Text>().text = GCharacter.gClass.Name;
    }
}
