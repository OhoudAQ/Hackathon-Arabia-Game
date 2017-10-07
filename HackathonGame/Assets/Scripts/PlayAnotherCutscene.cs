using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayAnotherCutscene : MonoBehaviour {

    public GameObject fadeOutEffect;
    public GameObject sCutscene;

    // Use this for initialization
    void Start()
    {
        var videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        //GameController.instance.JustWait(sCutscene);
        sCutscene.gameObject.SetActive(true);
       //StaticValues.level++;
       // GameController.instance.LoadLevel("Level" + StaticValues.level + "");
    }

}
