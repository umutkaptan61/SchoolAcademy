using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    //public float enemySpeed;
    public Vector2 center;
    public float enemySpeed3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, center, Time.deltaTime * enemySpeed3 * 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player3"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Center")
        {
            Destroy(gameObject);
        }
    }
}
