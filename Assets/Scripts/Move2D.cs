using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move2D : MonoBehaviour
{
    public float movespeed = 5f;
    public bool isGrounded = false;

    // Update is called once per frame
    void Update()
    {
        Jump();
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0 ,0);

        transform.position += movement * Time.deltaTime * movespeed;



    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") & isGrounded == true) 
        {
            
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        
        
        }
        



    }


}
