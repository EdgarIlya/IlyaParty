using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTreeAppleSpawner : MonoBehaviour
{
    public GameObject apple;
    public float TimeSpawn;
    void Start()
    {
        //При начале скрипта (начале игры) перейти к корутину SpawnCD
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        //Каждый кадр проверять SpawnCD на процесс выполнения, если не выполняется, тогда выполнять
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        //Подождать время, которое задаём в параметре  TimeSpawn, который находится в скрипте в объекте BigTreeAppleSpawn
        //Затем создаём яблоко, которая появляется в заданных пределах
        //Повторять всё это
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(apple, new Vector2 (Random.Range (-5.05f, -0.56f), 1.45f), Quaternion.identity);
        Repeat();
    }

}
