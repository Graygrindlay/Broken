using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DashScript : MonoBehaviour
{
    public GameObject cameraShake;
    public float duration = .15f;
    public float magnitude = .4f;
    
    private Rigidbody2D rb;
    
    private float dashTime;
    public float startDashTime;
   
    private static bool GroundCheck;
    public bool hasDashed;
    
    private int direction;

    private bool WDPressed = false;
    private bool WAPressed = false;
    private bool SDPressed = false;
    private bool SAPressed = false;
    
    public float thrust = 10;
    
    bool TD_Check;
    public float TD_Thrust = 5;



    
    
    void Start()
    {
        TD_Check = GetComponent<TopDown_Check>();
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        
    
    
    
    }


    private void Update()
    {
        dash();


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            WDPressed = true;
        }
        else
        {
            WDPressed = false;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            WAPressed = true;
        }
        else
        {
            WAPressed = false;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            SDPressed = true;
        }
        else
        {
            SDPressed = false;
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            SAPressed = true;
        }
        else
        {
            SAPressed = false;
        }
    }

    void dash()
    {
        GroundCheck = GroundedCheck.GroundCheck;

        if (direction == 0)
        {

            if (WDPressed & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 5;
                hasDashed = true;

            }
            else if (WAPressed & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 6;
                hasDashed = true;

            }
            else if (SDPressed & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 7;
                hasDashed = true;

            }
            else if (SAPressed & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 8;
                hasDashed = true;

            }

            if (Input.GetKey(KeyCode.A) & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 1;
                hasDashed = true;
            }
            else if (Input.GetKey(KeyCode.D) & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 2;
                hasDashed = true;
            }
            else if (Input.GetKey(KeyCode.W) & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
            {
                direction = 3;
                hasDashed = true;
            }
            else if (Input.GetKey(KeyCode.S) & Input.GetKeyDown(KeyCode.Space) & hasDashed == false)
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
                    rb.AddForce(-transform.right * thrust, ForceMode2D.Impulse);
                } 
                else if (direction == 2)
                {
                    rb.AddForce(transform.right * thrust, ForceMode2D.Impulse);
                }
                else if (direction == 3)
                {
                    rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                }
                else if (direction == 4)
                {
                    rb.AddForce(-transform.up * thrust, ForceMode2D.Impulse);
                }
                
                if (direction == 5) 
                {
                  rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                  rb.AddForce(transform.right * thrust, ForceMode2D.Impulse);
                }
                else if (direction == 6) 
                {
                  rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                  rb.AddForce(-transform.right * thrust, ForceMode2D.Impulse);
                }
                else if (direction == 7) 
                {
                  rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                  rb.AddForce(-transform.right * thrust, ForceMode2D.Impulse);
                }
                else if (direction == 8)
                {
                  rb.AddForce(-transform.up * thrust, ForceMode2D.Impulse);
                  rb.AddForce(-transform.right * thrust, ForceMode2D.Impulse);
                }
            }
        }
        
        if (GroundCheck == true)
        {
            hasDashed = false;
          
        }

        if (TD_Check == true)
        {
            hasDashed = false;

        }

        if (TD_Check == true)
        {
            thrust = TD_Thrust;

        }
                
    }




            
            
              



            


    

  

        
    
        









             
                
             
                           
                         
    
    
    
    
    
    
    

}
