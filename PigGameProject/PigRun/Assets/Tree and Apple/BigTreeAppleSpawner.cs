using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTreeAppleSpawner : MonoBehaviour
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
        Instantiate(apple, new Vector2 (Random.Range (-5.05f, -0.56f), 1.45f), Quaternion.identity);
        Repeat();
    }

}
