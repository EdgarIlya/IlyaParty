using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BompSpawn : MonoBehaviour
{
    public GameObject Bomb;
    public float TimeSpawn;
    void Start()
    {
        //При начале скрипта (начале игры) перейти к корутину SpawnBomb
        StartCoroutine(SpawnBomb());
    }

    void Repeat()
    {
        //Каждый кадр проверять SpawnBomb на процесс выполнения, если не выполняется, тогда выполнять
        StartCoroutine(SpawnBomb());
    }
    IEnumerator SpawnBomb()
    {
        //Подождать время, которое задаём в параметре  TimeSpawn, который находится в скрипте в объекте BombSpawn
        //Затем создаём бомбу, которая появляется в заданных пределах
        //Повторять всё это
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Bomb, new Vector2(Random.Range(-8.3f, 8.2f), 6f), Quaternion.identity);
        Repeat();
    }

}
