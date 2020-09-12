using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform player;
    
    void Update()
    {
        transform.LookAt(player);
    }
}
