using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // config params
    [SerializeField] PaddleMove paddle1;
    [SerializeField] float xPush = 1.5f;
    [SerializeField] float yPush = 15f;
    [SerializeField] AudioClip[] ballSounds;

    // state
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // cached component references
    AudioSource myAudioSource;
    
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (hasStarted == false)
        {
            LockBallToPaddle();
            LaunchBall();
        }
    }

    private void LaunchBall()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }

    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(hasStarted == true)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip);
        }
    }
}
