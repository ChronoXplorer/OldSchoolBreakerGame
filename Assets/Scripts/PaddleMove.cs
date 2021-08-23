using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    public float moveSpeed = 10f;

    private void Update()
    {
        PaddleMovement();
    }

    void PaddleMovement()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);
    }
}
