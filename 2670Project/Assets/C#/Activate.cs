using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject puzzleObject;
    private void OnTriggerEnter(Collider other)
    {
        puzzleObject.SetActive(true);
    }
}
