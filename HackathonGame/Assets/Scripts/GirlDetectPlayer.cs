using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlDetectPlayer : MonoBehaviour {

    public Transform girl;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            girl.parent = collision.gameObject.transform;

        }
    }
}
