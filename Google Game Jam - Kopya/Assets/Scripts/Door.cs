using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    public AudioSource openDoor;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("Door", true);
            if (openDoor != null)
            {
                openDoor.Play();
                Destroy(openDoor,2.5f);
            }
           
            //Destroy(openDoor, 2f);
            //GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
