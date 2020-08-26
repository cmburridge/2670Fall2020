using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float f = Input.GetAxisRaw("Vertical");
        
        
        gameObject.transform.position = new Vector3(transform.position.x + (h * speed),transform.position.y,transform.position.z + (f * speed));
    }
}
