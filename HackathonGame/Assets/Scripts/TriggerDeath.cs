using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeath : MonoBehaviour {
    public Bullet bullet;

    private void Awake()
    {
        bullet = GameObject.FindObjectOfType<Bullet>();
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            bullet.ShootAnimation();

        }
    }
}
