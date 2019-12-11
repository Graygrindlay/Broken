using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DashScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    private static bool GroundCheck;
    public bool hasDashed;
    public float duration = .15f;
    public float magnitude = .4f;
    public GameObject cameraShake;
    //private Vector3 lastMoveDir;
    private bool WDPressed = false;
    private bool WAPressed = false;
    private bool SDPressed = false;
    private bool SAPressed = false;
    void Start()
    {
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
                    Vector3 movement = new Vector3(-dashSpeed, 0, 0);
                    transform.position += movement * Time.deltaTime;
                } 
                else if (direction == 2)
                {
                    Vector3 movement = new Vector3(dashSpeed, 0, 0);
                    transform.position += movement * Time.deltaTime;
                }
                else if (direction == 3)
                {
                    Vector3 movement = new Vector3(0, dashSpeed, 0);
                    transform.position += movement * Time.deltaTime;
                }
                else if (direction == 4)
                {
                    Vector3 movement = new Vector3(0, -dashSpeed, 0);
                    transform.position += movement * Time.deltaTime;
                }
                else if (direction == 5)
                {
                    Vector3 movement = new Vector3(dashSpeed, dashSpeed, 0);
                    transform.position += movement * Time.deltaTime;

                }
                else if (direction == 6)
                {
                    Vector3 movement = new Vector3(-dashSpeed, dashSpeed, 0);
                    transform.position += movement * Time.deltaTime;

                }


            }
            
            
              

        }


        if (GroundCheck == true)
        {
            hasDashed = false;
            


        }    
    
    }

  

        
    
        









             
                
             
                           
                         
    
    
    
    
    
    
    

}
