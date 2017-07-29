using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;
    public float Gravity;

    private float _food = 0;
    public Text FoodText;

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

        FoodText.text = "Food : " + _food;
    }

    void Move()
    {
        _controller.Move(_movement * Time.deltaTime);
    }

    public void Collect(float food)
    {
        _food += food;
    }
}
