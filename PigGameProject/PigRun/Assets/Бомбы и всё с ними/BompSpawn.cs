using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BompSpawn : MonoBehaviour
{
    public GameObject Bomb;
    public float TimeSpawn;
    void Start()
    {
        StartCoroutine(SpawnBomb());
    }

    void Repeat()
    {
        StartCoroutine(SpawnBomb());
    }
    IEnumerator SpawnBomb()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Bomb, new Vector2(Random.Range(-8.3f, 8.2f), 6f), Quaternion.identity);
        Repeat();
    }

}
