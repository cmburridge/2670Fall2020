using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 5f;
    void Update()
    {
        var hInput = Input.GetAxis("Mouse X")* Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);
    }
}
