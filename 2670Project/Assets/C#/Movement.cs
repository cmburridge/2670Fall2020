using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    
    private CharacterController controller;
    private Vector3 _movement;
    public float gravity = 9.81f;
    public float moveSpeed = 3f;
    public float fastSpeed = 6f;
    public float jumpForce = 10f;
    public int jumpCountMax = 2;
    public int currentJumpCount;
    public float rotateSpeed = 3f;
    private Vector3 rotateMovement;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        rotateMovement.y = rotateSpeed * Input.GetAxis("Horizontal");
        transform.Rotate(rotateMovement);

        if (Input.GetButtonDown("Jump"))
        {
            if (currentJumpCount != jumpCountMax)
            {
                _movement.y = jumpForce; 
                currentJumpCount++;
            }
            else
            {
                return;
            }
        }

        if (controller.isGrounded)
        {
            _movement.y = 0;
            currentJumpCount = 0;
        }
        else
        {
            _movement.y -= gravity;
        }

        if (Input.GetButton("Fire1"))
        {
            _movement.x = Input.GetAxis("Horizontal")* fastSpeed;
            _movement.z = Input.GetAxis("Vertical")* fastSpeed;
        }
        else
        {
            _movement.x = Input.GetAxis("Horizontal")* moveSpeed;
            _movement.z = Input.GetAxis("Vertical")* moveSpeed;
        }

        _movement = transform.TransformDirection(_movement);
        controller.Move(_movement*Time.deltaTime);
    }
}
