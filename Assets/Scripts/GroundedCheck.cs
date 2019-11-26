using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GroundedCheck : MonoBehaviour
{
    public static bool GroundCheck;

    void OnCollisionStay2D(Collision2D collider)
    {
        CheckIfGrounded();
        Debug.Log(GroundCheck);
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        GroundCheck = false;

        Debug.Log(GroundCheck);
    }

    private void CheckIfGrounded()
    {
        RaycastHit2D[] hits;

        //We raycast down 1 pixel from this position to check for a collider
        Vector2 positionToCheck = transform.position;
        hits = Physics2D.RaycastAll(positionToCheck, new Vector2(0, -1), 0.01f);

        //if a collider was hit, we are grounded
        if (hits.Length > 0)
        {
            GroundCheck = true;
        }
    }


}
