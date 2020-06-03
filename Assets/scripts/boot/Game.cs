using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component runs at start time
//Its job is to control scenes
//it will be DDOL.
// you can reference this with Game game = Object.FindObjectOfType<Game>();
// game.loadLevel
public class Game : Singleton<Game>
{
    //currentScene;

    //singleton
    private static Game instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("badness");
        }
    }

    //a list containing all scenes currently being loaded.
    //currently there is no logic pushing to this.
    List<AsyncOperation> _sceneLoadOperations;


    private void Start()
    {
        _sceneLoadOperations = new List<AsyncOperation>();
    }

    private string _currentLevelName = string.Empty;

    // callback that runs whene a scene finishes loading
    void OnSceneLoadOperationComplete(AsyncOperation ao)
    {
        Debug.Log(" Scene Load Complete.");

        if (_sceneLoadOperations.Contains(ao))
        {
            _sceneLoadOperations.Remove(ao);

            //dispatch messag
            //transition between screnes
        }
    }

    void OnUnloadOperationComplete(AsyncOperation ao)
    {
        Debug.Log(" UNLoad Complete.");

    }

    // loads the scene, and also unloads the current scene
    public void LoadLevel(string levelName)
    {
        Debug.Log("Loading scene : " + levelName);
        try
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);

        }
        catch
        {
            Debug.LogError("error loading scene");
        }
    }

    //not sure about making this public, i want the load level method to auto unload the current scene
    void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[Game] Unable to unload level " + levelName);
            return;
        }
        ao.completed += OnUnloadOperationComplete;

    }





}
