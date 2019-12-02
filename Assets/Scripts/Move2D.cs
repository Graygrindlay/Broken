using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move2D : MonoBehaviour
{
    public float tempMoveSpeed = 5f;
    public float moveSpeed = 5f;
    public float runSpeed = 10f;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0 ,0);

        transform.position += movement * Time.deltaTime * tempMoveSpeed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            tempMoveSpeed = runSpeed;

        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            tempMoveSpeed = moveSpeed;

        }

    }

   


}
