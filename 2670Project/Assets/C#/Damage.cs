using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public IntData healthValue;
    public GameObject player;

    private void Start()
    {
        healthValue.value = 3;
    }

    private void OnTriggerEnter(Collider other)
    {
        healthValue.value--;
    }

    private void FixedUpdate()
    {
        if (healthValue.value <= 0)
        {
            Destroy(player);
        }
    }
}
