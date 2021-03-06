﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LookAtBehavior : MonoBehaviour
{
    public float speed = 3f;
    public float timer = 3f;
    public Transform objLocation;
    public bool enraged = false;
    public Animator enemyAnimate;
    public void LocatePlayer()
    {
        enraged = true;
    }

    public void LosePlayer()
    {
        enraged = false;
    }

    private void FixedUpdate()
        {
            if (enraged == true)
            {
                transform.LookAt(objLocation);
                transform.Translate(0,0,speed * Time.fixedDeltaTime);
                enemyAnimate.enabled = false;
            }
            else
            {
                enemyAnimate.enabled = true;
            }
        }
     
    public void OnLook(Vector3Data obj)
    {
        Transform transform1;
        (transform1 = transform).LookAt(obj.value);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
