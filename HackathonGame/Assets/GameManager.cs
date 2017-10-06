using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour {

    public GameObject movie;
    private VideoPlayer videoPlayer;

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

        //Play sc
        if (StaticValues.won && StaticValues.level == 1)
        {

        }

        if (StaticValues.won && StaticValues.level == 1)
        {

        }

    }
}
