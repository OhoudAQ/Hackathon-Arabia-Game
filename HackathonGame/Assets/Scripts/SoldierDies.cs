using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierDies : MonoBehaviour {

    private Animator m_Anim;            // Reference to the player's animator component.

    // Use this for initialization
    void Start () {
        m_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    //TODO play death animation
    public void Die()
    {

    }
}
