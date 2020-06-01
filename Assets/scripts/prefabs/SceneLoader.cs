using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoadScene()
    {
        Debug.Log("loading scene ");
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Dungeon");
    }
}
