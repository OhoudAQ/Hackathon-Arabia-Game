using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    private string levelToLoad;
 

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        instance = this;
    }
    // Use this for initialization
    void Start()
    {
        StaticValues.won = false;
        StaticValues.level = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator WaitBeforeLoading()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(levelToLoad, LoadSceneMode.Single);
    }
    public void LoadLevel(string id)
    {
        levelToLoad = id;
        StartCoroutine("WaitBeforeLoading");
    }
}
