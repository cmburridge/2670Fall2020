using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float moveSpeed = 5f, fastSpeed = 10f, rotateSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public int jumpCountMax = 2;
    private int jumpCount;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            var vInput = Input.GetAxis("Vertical")*fastSpeed;
            movement.Set(vInput,yVar,0);
        }
        else
        {
            var vInput = Input.GetAxis("Vertical")*moveSpeed;
            movement.Set(vInput,yVar,0);
        }
        
        
        var hInput = Input.GetAxis("Horizontal")* Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);

        yVar += gravity*Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount< jumpCountMax)
        {
            yVar = jumpForce;
            jumpCount++;
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}

