using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public IntData healthValue;
    public IntData damageValue;
    public IntData baseHealthValue;
    public GameObject player;
    
    private void Start()
    {
        healthValue.value = baseHealthValue.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        healthValue.value -= damageValue.value;
    }

    private void FixedUpdate()
    {
        if (healthValue.value <= 0)
        {
            Destroy(player);
        }
    }
}
