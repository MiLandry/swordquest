using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StrategicMapController : MonoBehaviour
{
    //add Edward to the party
    void Start()
    {


    }

    public void GoToDungeon()
    {
        SceneManager.LoadScene("Dungeon");
    }
}
