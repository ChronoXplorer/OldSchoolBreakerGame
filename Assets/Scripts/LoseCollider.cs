using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver();
    }

    private static void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
