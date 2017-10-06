using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    private Rigidbody2D rb2d;
	// Use this for initialization
	void Awake () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}


    public void moveBoxLeft()
    {
        rb2d.velocity = new Vector3(4f, 0f);
    }


    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "MiddleRowBrownbrick")
        {
            rb2d.gravityScale = 15;
        }
    }
}
