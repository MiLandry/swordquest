using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //populates game state with current monster party, and switches scene to combat
    public void fightMonsterParty()
    {
        Game game = Object.FindObjectOfType<Game>();
        game.LoadLevel("Combat");

    }
}
