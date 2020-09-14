using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private EnemyHealth eHealth;
    
    void Start()
    {
        eHealth = ScriptableObject.CreateInstance<EnemyHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        eHealth.value -= 1f;
    }
}
