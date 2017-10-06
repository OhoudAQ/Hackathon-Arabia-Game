using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour {

    public GameObject movie;
    private VideoPlayer videoPlayer;
    public int wonLevelInt = 0;
    public bool won = false;

	// Use this for initialization
	void Start () {
        StaticValues.won = false;
        StaticValues.level = 0;
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update () {

        //Play start cutscene
        if(StaticValues.won && StaticValues.level == 0)
        {
            videoPlayer.Play();
            Debug.Log("Played Start Cutscene!");
            videoPlayer.Play();
            Debug.Log("Played Dreams Word Cutscene!");

        }

        //Play scond cutscene
        if (StaticValues.won && StaticValues.level == 1)
        {

        }

        //Play third cutscene 
        if (StaticValues.won && StaticValues.level == 1)
        {

        }

        //Play the end cutscene
        if (StaticValues.won && StaticValues.level == 2)
        {

        }

    }
}
