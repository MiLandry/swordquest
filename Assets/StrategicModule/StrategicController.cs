using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategicController : MonoBehaviour
{


    public void LoadDungeon()
    {
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Dungeon");
    }
}
