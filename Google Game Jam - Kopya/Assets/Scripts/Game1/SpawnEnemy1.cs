using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy1 : MonoBehaviour
{
    public float randomWaitTime;
    public GameObject enemy1Prefab;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (randomWaitTime <= 0f)
        {
            randomWaitTime = Random.Range(0.2f, 1.5f);
            Instantiate(enemy1Prefab, transform.position, Quaternion.identity);
        }

        else
        {
            randomWaitTime -= Time.deltaTime;
        }

    }
}
