using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatusScript : MonoBehaviour
{
    // config parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointPerBlockDestroyed = 83;

    // state variables
    [SerializeField] int currentScore = 0;
    
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointPerBlockDestroyed;
    }
}
