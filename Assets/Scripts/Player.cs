using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;
    public float Gravity;

    private CharacterController _controller;
    private Vector3 _movement;

    void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (_controller.isGrounded)
        {
            // reset movement
            _movement = Vector3.zero;

            // Handle jump
            if (Input.GetButtonDown("Jump"))
            {
                _movement.y = JumpSpeed;
            }
        }

        // move verticaly
        _movement.x = Input.GetAxisRaw("Horizontal") * Speed;

        // Handle gravity
        _movement.y -= Gravity * Time.deltaTime;

        // Move the character
        Move();
    }

    void Move()
    {
        _controller.Move(_movement * Time.deltaTime);
    }
}
