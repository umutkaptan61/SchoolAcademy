using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        Destroy(gameObject,22f);
        rb2d = GetComponent<Rigidbody2D>();
        GoBall();
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(400, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-400, -15));
        }
    }
 

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player2"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y /2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb2d.velocity = vel;

            
        }

        if (coll.gameObject.CompareTag("DeathWall"))
        {
            Destroy(gameObject);
        }

        if (coll.gameObject.CompareTag("Game2Barier"))
        {
            Destroy(gameObject);
        }

      



    }
}
