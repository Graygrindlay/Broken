using UnityEngine;



public class PlayerCharacterMovement : MonoBehaviour
{

    public float speed = 10;
    float moveX = 0f;
    float moveY = 0f;
    private Vector3 lastMoveDir;


    private void Awake()
    {

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;

        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;

        }

        bool isIdle = moveX == 0 && moveY == 0;
        if (isIdle)
        {
            //playerCharacterBase.PlayIdleAnimation(lastMoveDir);
        }
        else
        {
            Vector3 moveDir = new Vector3(moveX, moveY).normalized;

            Vector3 targetMovePosition = transform.position + moveDir * speed * Time.deltaTime;
            RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, moveDir, speed * Time.deltaTime);
            if (raycastHit.collider == null)
            {
                // Can move, no hit
                lastMoveDir = moveDir;
                //playerCharacterBase.PlayWalkingAnimation(moveDir);
                transform.position = targetMovePosition;
            }
            else
            {
                // Cannot move diagonally, hit something

                // Test just moving in horizontal direction
                Vector3 testMoveDir = new Vector3(moveDir.x, 0f).normalized;
                targetMovePosition = transform.position + testMoveDir * speed * Time.deltaTime;
                raycastHit = Physics2D.Raycast(transform.position, testMoveDir, speed * Time.deltaTime);
                if (testMoveDir.x != 0f && raycastHit.collider == null)
                {
                    // Can move horizontally
                    lastMoveDir = testMoveDir;
                    //playerCharacterBase.PlayWalkingAnimation(testMoveDir);
                    transform.position = targetMovePosition;
                }
                else
                {
                    // Cannot move horizontally

                    // Test just moving in vertical direction
                    testMoveDir = new Vector3(0f, moveDir.y).normalized;
                    targetMovePosition = transform.position + testMoveDir * speed * Time.deltaTime;
                    raycastHit = Physics2D.Raycast(transform.position, testMoveDir, speed * Time.deltaTime);
                    if (testMoveDir.y != 0f && raycastHit.collider == null)
                    {
                        // Can move vertically
                        lastMoveDir = testMoveDir;
                        //playerCharacterBase.PlayWalkingAnimation(testMoveDir);
                        transform.position = targetMovePosition;
                    }
                    else
                    {
                        // Cannot move vertically
                        //playerCharacterBase.PlayIdleAnimation(lastMoveDir);
                    }
                }

            }
        }

        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
     
    }
}
