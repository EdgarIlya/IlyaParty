using System.Collections;
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
    }
}
