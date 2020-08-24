using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

    public bool canRun;
    public string password;
    public int number;
    
    // Start is called before the first frame update
    void Start()
    {
         if (!canRun)
         {
             Debug.Log("Running");
         }
         
         //Shorthand If Statement
         Debug.Log(password == "OU812" ? "Correct" : "Incorrect");

         if (number >= 7)
         {
             Debug.Log("Greater Than 7");
         }
         else
         {
             Debug.Log("Less Than 7");
         }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
