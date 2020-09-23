using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            Camera.main.orthographic = true;
        }
        else
        {
            Camera.main.orthographic = false;
        }
        
    }
}
