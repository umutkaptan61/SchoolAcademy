using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    private float dirY = 0f;

    [SerializeField] private float moveSpeed = 7f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

  
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeed);

        WalkAnimation();
    }


    private void WalkAnimation()
    {
        if (dirX == 0f)
        {
            anim.SetBool("walk", false);
            anim.SetBool("right", false);
            anim.SetBool("left", false);
        }

        if (dirX > 0f)
        {
            anim.SetBool("right", true);            
        }
        else if (dirX < 0f)
        {         
            anim.SetBool("left", true);          
        }      

        if (rb.velocity.y == 0)
        {
            anim.SetBool("up", false);
            anim.SetBool("down", false);

        }

        if (rb.velocity.y > .1f)
        {
            anim.SetBool("up", true);
        }
        else if (rb.velocity.y < -.1f)
        {
            anim.SetBool("down", true);
        }
     
    }
}
