using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilTreeAppleSpawn : MonoBehaviour
{
    public GameObject apple;
    public float TimeSpawn;
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(apple, new Vector2(Random.Range(4.99f, 7.56f), 1.11f), Quaternion.identity);
        Repeat();
    }

}
