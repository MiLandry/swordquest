using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PartySelectionController : MonoBehaviour
{
  public void SelectWarriorParty()
  {
    Debug.Log("aoei");
    SceneManager.LoadScene("StrategicMap");
  }
}
