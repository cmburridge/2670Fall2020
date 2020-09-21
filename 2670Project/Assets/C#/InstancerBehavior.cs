using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstancerBehavior : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data rotationDirection;
    public void Instance()
    {
        var location = transform.position;
        var rotationDirection = new Vector3(0f,0f,0f);
        Instantiate(prefab, location, Quaternion.Euler(rotationDirection));
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instance();
        }
    }
}
