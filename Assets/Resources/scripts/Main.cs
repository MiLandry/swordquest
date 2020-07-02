using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// main, aka the 'prescene', it runs on game start, at any scene. It creates a game object
// (a prefab), called Main. This prefab is a container for all scripts to run at boot time.
// this container can containe services.
// note that these services will have to determine if they are destroyable, not managed here.
// You can choose to add any "Service" component to the Main prefab.
//They will be added as scripts. Call them "Service" they are stateful.
// Examples are: Input, Saving, Sound, Config, Asset Bundles, Advertisements
public class Main : MonoBehaviour
{
    // Runs before a scene gets loaded
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void LoadMain()
    {
        Debug.Log("Pre-scene loading...");
        Debug.Log("Pre-scene: creating main game object ...");
        GameObject main = GameObject.Instantiate(Resources.Load("Main")) as GameObject;
        DontDestroyOnLoad(main);

    }

}
