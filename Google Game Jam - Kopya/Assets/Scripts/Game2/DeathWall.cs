using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{
    public GameObject mainCharacter;

    public GameObject mainCam;

    public GameObject game2;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy2")
        {
            Game2Manager.finishTime = 21f;
            //Game1Manager.finishTime = 21f;
            //transform.position = startPos.transform.position;
            mainCam.transform.position = new Vector3(-10.38f, -1.35f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            game2.SetActive(false);
        }
    }
}
