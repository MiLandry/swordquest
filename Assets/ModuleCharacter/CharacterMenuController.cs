using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMenuController : MonoBehaviour
{
    public void OnBackClick()
    {
        Debug.Log("back btn clicked");
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Strategic");
    }
}
