using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{
    private float horizontal;
    public float playerSpeed;
    public float jumpingPower;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public GameObject mainCharacter;

    public GameObject mainCam;

    public GameObject game1;

    public GameObject startPos;

    private void Start()
    {
        //StartCoroutine(backToRoom());
        //deathMusic = false;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * playerSpeed, rb.velocity.y);
    }


    void Update()
    {
        
        //game1.SetActive(false);
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        {
            Game1Manager.finishTime = 21f;
            transform.position = startPos.transform.position;
            mainCam.transform.position = new Vector3(10.23f, -1.39f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            game1.SetActive(false);
        }
    }
    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         if (collision.gameObject.tag == "Ball")
         {
             //deathMusic = true;
             Destroy(game1);
             //GameManager.game1End = true;
             //GameManager.gameEndPanel = true;
         }
     }*/

    /* IEnumerator backToRoom()
     {
         yield return new WaitForSeconds(3f);       
         mainCam.transform.position = new Vector3(10.23f, -1.39f, -10f);
         mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
         game1.SetActive(false);
     }*/
}
