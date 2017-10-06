﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    private Rigidbody2D rb2d;
    private CapsuleCollider2D cc2d;
    Vector3 forceVector;

    bool isShot = false;
    private Animator m_Anim;            // Reference to the player's animator component.

    void Awake()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        cc2d = gameObject.GetComponent<CapsuleCollider2D>();
        m_Anim = GetComponent<Animator>();

    }
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Shoot()
    {
        if (!isShot)
        {
            Debug.Log("Bullet shot");
            forceVector = -this.transform.right;
            if (rb2d != null)
                rb2d.AddForce(forceVector * 3 * 1.5f, ForceMode2D.Impulse);
        }
    }

    public void ShootAnimation()
    {
       // m_Anim.Play();

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.name == "SoldierDies")
        {
            Debug.Log("Bullet OnTriggerExit2D");
            cc2d.isTrigger = false;
            forceVector = this.transform.right;
        
            rb2d.AddForce(forceVector * 4 * 2f, ForceMode2D.Force);

            rb2d.gravityScale = 5;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "MiddleRowBrownbrick")
        {
           // Destroy(rb2d);
        }
    }
}
