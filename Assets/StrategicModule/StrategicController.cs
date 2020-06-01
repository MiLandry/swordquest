using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategicController : MonoBehaviour
{


    public void LoadDungeon()
    {
        Debug.Log("loading scene ");
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Dungeon");
        game.UnloadLevel("Strategic");
    }
}
