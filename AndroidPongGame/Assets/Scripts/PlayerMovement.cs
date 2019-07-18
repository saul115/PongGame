using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject paddle;
    //public GameObject ball;
   


    void Start()
    {
       // paddle = GameObject.Find("Paddle");
        //ball = GameObject.Find("Ball");

      
        //transform.position = new Vector3(-7.74f,-0.07f,0);
    }

    // Update is called once per frame
    void Update()
    {



             Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

             transform.position = new Vector3(transform.position.x, Mathf.Clamp(mousePosition.y, -3.8f, 3.8f), transform.position.z);


   

        
    }
}
