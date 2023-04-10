using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Center : MonoBehaviour
{
    public GameObject mainCharacter;

    public GameObject mainCam;

    public GameObject game3;

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy3")
        {
            Game3Manager.finishTime = 21f;
            //Game1Manager.finishTime = 21f;
            //transform.position = startPos.transform.position;
            mainCam.transform.position = new Vector3(10.16f, 14f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            game3.SetActive(false);
        }
    }
}
