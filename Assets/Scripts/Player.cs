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
    private Vector3 _lastPosition;
    [SerializeField]
    private float _timeNotMoved;
    [SerializeField]
    private float _timeMaxNotMoved;

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

        if (!_controller.isGrounded)
        {
            if (_lastPosition.y != transform.position.y)
            {
                _timeNotMoved = 0;
                _lastPosition = transform.position;
            }
            else
            {
                _timeNotMoved += Time.deltaTime;
            }

            if (_timeNotMoved >= _timeMaxNotMoved)
            {
                _movement.y = 0;
            }
        }

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
