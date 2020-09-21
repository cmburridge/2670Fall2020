using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject puzzleObject;
    private bool objState = true;

    private void OnTriggerEnter(Collider other)
    {
        if (objState == true)
        {
           puzzleObject.SetActive(true);
           objState = false;
        }
        else
        {
            puzzleObject.SetActive(false);
            objState = true;
        }

    }
}
