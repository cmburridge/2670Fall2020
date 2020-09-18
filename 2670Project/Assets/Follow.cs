using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject followObj;
    public Transform objLocation;
    public float speed = 2.0f;

    void Update()
    {

        if (Vector3.Distance(transform.position, objLocation.position) < 10f)
        {
           return; 
        }
        else
        {
             float interpolation = speed * Time.deltaTime;
            
             Vector3 position = this.transform.position;
             position.y = Mathf.Lerp(this.transform.position.y, followObj.transform.position.y, interpolation);
             position.x = Mathf.Lerp(this.transform.position.x, followObj.transform.position.x, interpolation);
            
             this.transform.position = position;
        }
       
    }
}
