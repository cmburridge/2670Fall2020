using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehavior : MonoBehaviour
{
    public Transform objLocation;
    private void Update()
    {
        transform.LookAt(objLocation);
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
