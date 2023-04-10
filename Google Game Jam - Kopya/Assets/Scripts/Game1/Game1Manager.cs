using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game1Manager : MonoBehaviour
{
    public static float finishTime = 21f;
    //public float baseFinishTime;
    public Text finishTimeText;

    public GameObject game1;
    public GameObject mainCam;
    public GameObject mainCharacter;

    public GameObject player1;
    public GameObject startPos;


    void Start()
    {
        //finishTime = baseFinishTime;
    }

    
    void Update()
    {
        finishTime -= Time.deltaTime;
        finishTimeText.text = "" + (int)finishTime;

        if (finishTime <= 0f)
        {
            mainCam.transform.position = new Vector3(10.23f, -1.39f, -10f);
            mainCharacter.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            player1.transform.position = startPos.transform.position;
            game1.SetActive(false);
            finishTime = 21f;
        }
    }
}
