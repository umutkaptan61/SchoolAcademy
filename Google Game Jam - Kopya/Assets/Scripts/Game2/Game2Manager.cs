using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2Manager : MonoBehaviour
{
    public static float finishTime = 21f;

    public GameObject player2;

    public GameObject enemyPrefab2;
    public GameObject enemyPrefab2_2;

    //public static float finishTime = 21f;   
    public Text finishTimeText;

    public GameObject game2;
    public GameObject mainCam;
    public GameObject mainCharacter;

    public GameObject playerStartPos;
    public GameObject enemy2StartPos;
    public GameObject enemy2_2StartPos;

    public static bool enemy2Enabled = false;

    //public GameObject enemyPrefab2_2;


    /* void Start()
     {
         Invoke("OpenEnemy2", 10f);
     }
    */

    void Update()
    {
        finishTime -= Time.deltaTime;
        finishTimeText.text = "" + (int)finishTime;

        if (finishTime <= 10f && enemy2Enabled == false)
        {
            Instantiate(enemyPrefab2_2, enemy2_2StartPos.transform.position, Quaternion.identity);
            enemy2Enabled = true;
        }

        if (finishTime <= 0f)
        {
            mainCam.transform.position = new Vector3(-10.38f, -1.35f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            player2.transform.position = playerStartPos.transform.position;
            //enemyPrefab2.transform.position = enemy2StartPos.transform.position;
            //enemy2_2StartPos.transform.position = enemy2_2StartPos.transform.position;
            game2.SetActive(false);
            finishTime = 21f;
        }
   
    }

   

   
}
