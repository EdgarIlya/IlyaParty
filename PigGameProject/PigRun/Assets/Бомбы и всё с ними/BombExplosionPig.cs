using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosionPig : MonoBehaviour  

{
    public bool IsExplosive;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pig")
        {
            anim.SetBool("IsExplosive", true);
            StartCoroutine(DestroyExplosionPig());
        }
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }

        if ((collision.gameObject.tag == "Ground") || (collision.gameObject.tag == "apple") || (collision.gameObject.tag == "Bomb"))
        {
            StartCoroutine(DestroyExplosionLifeEnd());
        }
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }

    }
    IEnumerator DestroyExplosionPig()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
    }

    IEnumerator DestroyExplosionLifeEnd()
    {
        while (true)
        {

            yield return new WaitForSeconds(3f);
            anim.SetBool("IsExplosive", true);
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
    }
}
