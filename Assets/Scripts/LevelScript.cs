using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    // parameters
    [SerializeField] int breakableBlocks; // Serialized for the purpose of debugging

    // cached references
    SceneLoader sceneloader;

    public void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
