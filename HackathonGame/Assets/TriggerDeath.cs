using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeath : MonoBehaviour {
    public GameObject bullet;

    private void Awake()
    {

        

    }
    //TODO
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
           // bullet.GetComponent<Animation>().Play("BulletShoot");

        }
    }
}
