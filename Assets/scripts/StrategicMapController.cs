using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StrategicMapController : MonoBehaviour
{
  public void GoToDungeon()
  {
    SceneManager.LoadScene("Dungeon");
  }
}
