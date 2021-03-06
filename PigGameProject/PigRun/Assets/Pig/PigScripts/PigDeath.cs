﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigDeath : MonoBehaviour
{
    public bool isBombTouch;
    private Animator anim;
    private Rigidbody2D rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    //При соприкосновении свинки с бомбами перейти в корунтин PigDeathProcess
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
            //Подождать 0.7 секунды, затем проиграть анимацию взрыва у объекта "Pig" (Свинки), подождать 1 секунду, пока анимация проиграется и закончится
            //Удалить объект свинку

            //yield return new WaitForSeconds(0.7f);
            sharedvariables.StopFlip = true;
            //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            anim.SetBool("NotDetonate", false);
            yield return new WaitForSeconds(0.1f);
            anim.SetBool("isBombTouch", true);
            yield return new WaitForSeconds(0.5f);
            Destroy(gameObject);
        }
    }

}
