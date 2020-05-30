using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    //currentScene;
    // load and unload game levels
    // game state
    // other manager instances generate other persistent sysstems
    // clean up code
    // start up code
    //TODO create a list of async Operations currently running
    // you would have maually and and remove on the defined callbacks below

    //singleton
    private static GameManager instance;

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

    List<AsyncOperation> _loadOperations;


    private void Start()
    {


        DontDestroyOnLoad(gameObject);
        _loadOperations = new List<AsyncOperation>();
        LoadLevel("StartScreen");
    }

    private string _currentLevelName = string.Empty;

    void OnLoadOperationComplete(AsyncOperation ao)
    {
        Debug.Log(" Load Complete.");

        if (_loadOperations.Contains(ao))
        {
            _loadOperations.Remove(ao);

            //dispatch messag
            //transition between screnes
        }
    }

    void OnUnloadOperationComplete(AsyncOperation ao)
    {
        Debug.Log(" UNLoad Complete.");

    }

    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }
        _currentLevelName = levelName;
        ao.completed += OnLoadOperationComplete;

    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
        ao.completed += OnUnloadOperationComplete;

    }




    //private void LoadLevel(string levelName)
    //{
    //    AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Single);
    //    if (ao == null)
    //    {
    //        Debug.LogError("[GameManager] Unable to load level " + levelName);
    //        return;
    //    }
    //    ao.completed += OnLoadOperationComplete;

    //    currentLevelName = levelName;
    //}


}
