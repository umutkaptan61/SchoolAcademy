using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public float enemySpeed;



    
    void Update()
    {        
        rb.AddForce(new Vector3(1f, 0f, 0f) * enemySpeed * Time.deltaTime);    
    }
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
