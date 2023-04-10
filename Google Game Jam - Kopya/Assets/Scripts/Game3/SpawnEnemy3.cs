using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy3 : MonoBehaviour
{
    public List<GameObject> spawnPoints = new List<GameObject>();

    public float waitTime;
    public GameObject enemyPrefab;

    // Update is called once per frame
    void Update()
    {
        if (waitTime <= 0f)
        {
            waitTime = 1.5f;
            Instantiate(enemyPrefab, spawnPoints[Random.Range(0, 6)].transform.position, Quaternion.identity);
        }

        else
        {
            waitTime -= Time.deltaTime;
        }
    }
}
