﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{


    public Transform paddle;
    public bool gameStarted = false;

    public Rigidbody2D rbBall;


    float positionDifference = 0;


    public AudioSource ballAudio;

    // Start is called before the first frame update
    void Start()
    {
         positionDifference = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {

            
            transform.position = new Vector3(paddle.position.x - positionDifference, paddle.position.y, paddle.position.z);

            if(Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(12, 12);
                gameStarted = true;
            }

        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballAudio.Play();
    }
}
