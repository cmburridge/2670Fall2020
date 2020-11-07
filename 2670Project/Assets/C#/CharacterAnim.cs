using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
   private Animator anim;

   private void Start()
   {
      anim = GetComponent<Animator>();
   }

   private void Update()
   {
      if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
      {
         anim.SetBool("Is running", true);
      }
      else
      {
         anim.SetBool("Is running", false);
      }
      
      if (Input.GetKey
         (KeyCode.UpArrow))
      {
         anim.SetBool("Is jumping", true);
      }
      else
      {
         anim.SetBool("Is jumping", false);
      }
   }
}
