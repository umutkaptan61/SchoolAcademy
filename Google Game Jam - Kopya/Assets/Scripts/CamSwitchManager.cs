using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchManager : MonoBehaviour
{
    //public GameObject anaNesne;
    public GameObject cam;
    /*public GameObject bos;
    public int altNesne1;*/
    public GameObject computer1;
    public GameObject computer2;
    public GameObject computer3;

    private bool camGame1 = false;

   /* private bool computerEnabled1 = false;
    private bool computerEnabled2 = false;
    private bool computerEnabled3 = false;*/

    void Update()
    {
        if (camGame1 == false)
        {
            cam.transform.parent = this.transform;
            transform.GetChild(0).localPosition = new Vector3(0f, 0f, -10f);
        }
         
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (camGame1 == false)
        {       
             if (collision.gameObject.CompareTag("Cam1"))
             {
                 transform.DetachChildren();
                 
                 cam.transform.position = new Vector3(10.23f, -1.39f, -10f);
                
                 
                 camGame1 = true;
                    //computerEnabled1 = true
                    //computer1.GetComponent<BoxCollider2D>().enabled = true;
             }
            
            
        }

        else if (camGame1 == true)
        {        
             if (collision.gameObject.CompareTag("CamOut1"))
             {
                 camGame1 = false;
                if (computer1 != null)
                {
                    computer1.GetComponent<BoxCollider2D>().enabled = true;
                }
                 
             }
            
            
        }

        if (camGame1 == false)
        {
            if (collision.gameObject.CompareTag("Cam2"))
            {
                transform.DetachChildren();
                cam.transform.position = new Vector3(-10.38f, -1.35f, -10f);
                camGame1 = true;
                Game2Manager.enemy2Enabled = false;
                //computerEnabled1 = true;
            }
        }

        else if (camGame1 == true)
        {
            if (collision.gameObject.CompareTag("CamOut2"))
            {
                camGame1 = false;
                if (computer2 != null)
                {
                    computer2.GetComponent<BoxCollider2D>().enabled = true;
                }
               
            }
        }

        if (camGame1 == false)
        {
            if (collision.gameObject.CompareTag("Cam3"))
            {
                transform.DetachChildren();
                cam.transform.position = new Vector3(10.16f, 14f, -10f);
                camGame1 = true;
                //computerEnabled1 = true;
            }
        }

        else if (camGame1 == true)
        {
            if (collision.gameObject.CompareTag("CamOut3"))
            {
                camGame1 = false;
                if (computer3 != null)
                {
                    computer3.GetComponent<BoxCollider2D>().enabled = true;
                }
                
            }
        }

        if (camGame1 == false)
        {
            if (collision.gameObject.CompareTag("Cam4"))
            {
                transform.DetachChildren();
                cam.transform.position = new Vector3(-10.37f, 14f, -10f);
                camGame1 = true;
                //computerEnabled1 = true;
            }
        }

        else if (camGame1 == true)
        {
            if (collision.gameObject.CompareTag("CamOut4"))
            {
                camGame1 = false;
                //computer3.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
  
}
