using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutCutscene : MonoBehaviour {
    public GameObject fadeOutEffect;

	// Use this for initialization
	void Start () {
        var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        Debug.Log("END!");
        fadeOutEffect.SetActive(true);
        StaticValues.level++;
        GameController.instance.LoadLevel("Level"+StaticValues.level+"");
    }

    
}
