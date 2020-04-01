using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigDeath : MonoBehaviour
{
    public bool isBombTouch;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            StartCoroutine(PigDeathProcess());
        }

    }
    IEnumerator PigDeathProcess()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.7f);
            anim.SetBool("isBombTouch", true);
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
    }

}
