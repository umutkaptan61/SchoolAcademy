using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    public GameObject game1;
    public GameObject game2;
    public GameObject game3;

    private Rigidbody2D rb;
    public GameObject mainCam;

    public GameObject computer1;
    public GameObject computer2;
    public GameObject computer3;

    public GameObject enemyPrefab2;
    public GameObject enemyPrefab2_2;

    public GameObject playerStartPos;
    public GameObject enemy2StartPos;
    public GameObject enemy2_2StartPos;

    private bool destroy1 = false;
    private bool destroy2 = false;
    private bool destroy3 = false;

    public float finishedGameNumber;

    public GameObject door1;
    public GameObject door2;

    void Start()
    {
        door1.GetComponent<BoxCollider2D>().enabled = false;
        door2.GetComponent<BoxCollider2D>().enabled = false;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Game1Manager.finishTime <= 0.2f && destroy1 == false)
        {
            finishedGameNumber++;
            Destroy(computer1);
            destroy1 = true;

        }

        if (Game2Manager.finishTime <= 0.2f && destroy2 == false)
        {
            finishedGameNumber++;
            Destroy(computer2);
            destroy2 = true;
        }

        if (Game3Manager.finishTime <= 0.2f && destroy3 == false)
        {
            finishedGameNumber++;
            Destroy(computer3);
            destroy3 = true;
        }

        if (finishedGameNumber == 3f)
        {
            door1.GetComponent<BoxCollider2D>().enabled = true;
            door2.GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Computer1")
        {            
            mainCam.transform.position = new Vector3(40.17f, -1.355f, -10f);
            game1.SetActive(true);
            rb.bodyType = RigidbodyType2D.Static;
            computer1.GetComponent<BoxCollider2D>().enabled = false;
        }

       
        if (collision.gameObject.tag == "Computer2")
        {
            Instantiate(enemyPrefab2, enemy2StartPos.transform.position, Quaternion.identity);
           // StartCoroutine(wait10Seconds());
           

            mainCam.transform.position = new Vector3(-37.09f, 0.03f, -10f);
            game2.SetActive(true);
            rb.bodyType = RigidbodyType2D.Static;
            computer2.GetComponent<BoxCollider2D>().enabled = false;
        }


        if (collision.gameObject.tag == "Computer3")
        {
            mainCam.transform.position = new Vector3(36.28f, 14, -10f);
            game3.SetActive(true);
            rb.bodyType = RigidbodyType2D.Static;
            computer3.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "EndDoor")
        {
            SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        }
    }



  /*  IEnumerator wait10Seconds()
    {
        yield return new WaitForSeconds(10f);      
        Instantiate(enemyPrefab2_2, enemy2_2StartPos.transform.position, Quaternion.identity);      
    }*/

    /*public void SpawnEnemy2()
    {
        if (Game2Manager.finishTime == 20f)
        {

        }
    }*/
}
