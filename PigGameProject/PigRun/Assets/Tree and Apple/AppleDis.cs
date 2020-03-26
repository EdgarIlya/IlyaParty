﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDis : MonoBehaviour
{
    public int price;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Pig")
        {
          ApplePlayer.apple += price;
          GameObject.FindGameObjectWithTag("Pig").GetComponent<ApplePlayer>().TextApple.text = ApplePlayer.apple.ToString();
          Destroy(gameObject);
        }
        else if ((collision.gameObject.name == "TransparentVertical") || (collision.gameObject.name == "TransparentVertical1") || (collision.gameObject.name == "TransparentHorizontal") || (collision.gameObject.name == "TransparentHorizontal1"))
        {
            Destroy(gameObject);
        }
    }
}
