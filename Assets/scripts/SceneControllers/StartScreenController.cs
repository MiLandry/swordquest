using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("you pressed space");
            UnityEngine.SceneManagement.SceneManager.LoadScene("PartySelection");


        }
    }
}
