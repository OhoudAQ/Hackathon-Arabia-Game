using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutscenesManager : MonoBehaviour {

    public GameObject[] scenes;
    private int currentLevel;

	// Use this for initialization
	void Start () {
        currentLevel = StaticValues.level;
        PlayCutscene(currentLevel);

    }
	
	public void PlayCutscene(int current)
    {
        scenes[current].gameObject.SetActive(true);
    }
}
