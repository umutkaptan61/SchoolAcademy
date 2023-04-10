using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game3Manager : MonoBehaviour
{
    //public GameObject player3;

    /*public GameObject enemyPrefab2;
    public GameObject enemyPrefab2_2;*/
    public static float finishTime = 21f;

    //public static float finishTime = 21f;
    public Text finishTimeText;

    public GameObject game3;
    public GameObject mainCam;
    public GameObject mainCharacter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        finishTime -= Time.deltaTime;
        finishTimeText.text = "" + (int)finishTime;

        if (finishTime <= 0f)
        {
            mainCam.transform.position = new Vector3(10.16f, 14f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            game3.SetActive(false);
            finishTime = 21f;
        }
    }
}
