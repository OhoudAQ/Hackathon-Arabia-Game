using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmineDeath : MonoBehaviour {

    public Animator DeathAnim;
    public Animator NormalAnim;
    public GameObject fire;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            NormalAnim.enabled = false;
        DeathAnim.enabled = true;
            fire.gameObject.SetActive(true);//also play explosin effect + wait and replay level

        }else{
            Destroy(gameObject);
        fire.gameObject.SetActive(true);

        }

    }

    IEnumerator DisableFire()
    {
        yield return new WaitForSeconds(0.5f);
        fire.gameObject.SetActive(false);
    }
}
