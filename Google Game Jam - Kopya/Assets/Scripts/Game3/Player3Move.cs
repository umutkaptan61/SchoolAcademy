using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Move : MonoBehaviour
{
    public Transform target;
    public float playerSpeed;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(target.transform.position, -target.transform.forward, playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(target.transform.position, target.transform.forward, playerSpeed * Time.deltaTime);
        }
    }


    
}
