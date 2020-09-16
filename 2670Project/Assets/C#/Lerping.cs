﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    public Vector3 vOne, vTwo;
    public float value;

    void Update()
    {
        var direction = Vector3.Lerp(vOne, vTwo, value);
        value += 0.1f * Time.deltaTime;
        transform.position = direction;
    }
}
