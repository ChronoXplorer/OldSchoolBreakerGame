using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // Serialized for the purpose of debugging

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
