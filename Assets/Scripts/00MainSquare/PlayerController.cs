using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rigidBody;
    private SpriteRenderer characterRenderer;
    private Vector2 moveInput;
    
    void Awake()
    {
        Time.timeScale = 1f;
        rigidBody = GetComponent<Rigidbody2D>();
        characterRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        if (moveInput.x < 0)
        {
            characterRenderer.flipX = true;
        }
        else if (moveInput.x > 0)
        {
            characterRenderer.flipX = false;
        }
    }

    void FixedUpdate()
    {
        rigidBody.velocity = moveInput * moveSpeed;
    }
}