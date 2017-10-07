using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneManager : MonoBehaviour {

    public bool won = false;


	
	// Update is called once per frame
	void Update ()
    {
	    if(won)
        {
            StaticValues.won = true;
            
            GameController.instance.LoadLevel("CutscenesHub");
        }	
	}
}
