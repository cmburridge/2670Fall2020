﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data vData;

    //Set vData from position value

    private void OnTriggerEnter(Collider other)
    {
        vData.SetValueFromTransform(transform.position);
    }
    
}
