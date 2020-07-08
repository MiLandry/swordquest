using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategicController : MonoBehaviour
{

    Game game;
    void Start()
    {
        Debug.Log("StrategicController starting...");
        game = Object.FindObjectOfType<Game>();
        
    }
    public void LoadDungeon()
    {
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Dungeon");
    }

    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            print("p was pressed");
            game.LoadLevel("Character Menu");
        }


    }
}
