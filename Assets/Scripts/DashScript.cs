using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class DashScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    private static bool GroundCheck;
    public bool hasDashed;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
            
    
    
    
    }



    void Update()
    {
        GroundCheck = GroundedCheck.GroundCheck;

        if (direction == 0) 
        {
            if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.Space) & hasDashed == false)
             
            {
             direction = 1;
             hasDashed = true;               
            
            } 
            else if (Input.GetKey(KeyCode.D) & Input.GetKey(KeyCode.Space) & hasDashed == false)
            {
            direction = 2;
            hasDashed = true;
            }
            else if (Input.GetKey(KeyCode.W) & Input.GetKey(KeyCode.Space) & hasDashed == false)
            {
            direction = 3;
            hasDashed = true;
            }
            else if (Input.GetKey(KeyCode.S) & Input.GetKey(KeyCode.Space) & hasDashed == false)
            {
            direction = 4;
            hasDashed = true;
            
            }



        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
                if(direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                } 
                else if (direction == 2)
                {
                rb.velocity = Vector2.right * dashSpeed;
                }
                else if (direction == 3)
                {
                rb.velocity = Vector2.up * dashSpeed;
                }
                else if (direction == 4)
                {
                rb.velocity = Vector2.down * dashSpeed;
                }


            }
            
            
              

        }


        if (GroundCheck == true)
        {
            hasDashed = false;
            


        }    
    
    
    
    
    
    
    
    
    
    
    }

}
