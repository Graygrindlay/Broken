using UnityEngine;



public class PlayerCharacterMovement : MonoBehaviour
{

    public float speed = 10;
    float moveX = 0f;
    float moveY = 0f;
    private Vector3 lastMoveDir;


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

        Vector3 moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;


        



    }
}
