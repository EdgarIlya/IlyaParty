using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplosionPig : MonoBehaviour

    private bool IsExplosive;

{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pig")
        {
            IsExplosive = true;
            Destroy(gameObject);
        }
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }
    }
}
