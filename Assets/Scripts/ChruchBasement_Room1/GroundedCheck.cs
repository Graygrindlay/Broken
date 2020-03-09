using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GroundedCheck : MonoBehaviour
{
    public static bool GroundCheck;

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.collider.tag == "Ground")
        {
            GroundCheck = true;
            Debug.Log("grounded");
        }

    }

    void OnCollisionExit2D(Collision2D collider)
    {
        GroundCheck = false;

        
    }

   


}
