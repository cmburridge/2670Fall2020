﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public FloatData moveSpeed, fastSpeed;
    public FloatData normalSpeed;

    public Vector3Data currentSpawnPoint;
    
    public FloatData MoveSpeed => moveSpeed;

    public IntData playerJumpCount;
    private int jumpCount;
    
    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        {
            var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
            movement.Set(vInput,yVar,0);
        }
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
        
        var hInput = Input.GetAxis("Horizontal")* Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);

        yVar += gravity*Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount< playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }

    private void OnEnable()
    {
        //set the position of player to the location data of the player
    }
}

