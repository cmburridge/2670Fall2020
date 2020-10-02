using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LookAtBehavior : MonoBehaviour
{
    public float speed = 3f;
    public float timer = 3f;
    public Transform objLocation;
    public bool enraged = false;
    public void LocatePlayer()
    {
        enraged = true;
    }
    
    private void FixedUpdate()
        {
            if (enraged == true)
            {
                transform.LookAt(objLocation);
                transform.Translate(0,0,speed * Time.fixedDeltaTime);
            }

            if (enraged == false)
            {
               if ( this.tag == "Enemy")
               {
                   timer -= Time.fixedDeltaTime;
                   if (timer <= 0f)
                   {
                       timer += 3f;
                       transform.Rotate(0,90,0);
                       Debug.Log("searching");
                   }
               } 
            }
        }
     
    public void OnLook(Vector3Data obj)
    {
        Transform transform1;
        (transform1 = transform).LookAt(obj.value);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transformRotation.y -= 90;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
