using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplingHook : MonoBehaviour
{

    public SpriteRenderer crosshairSprite;
    public Transform crosshair;
    private bool ropeAttached;
    public Move2D playerMovement;
    public float cursorDistance = 2f;
    //Cursor handling ^

    DistanceJoint2D joint;
    Vector3 targetPos;
    RaycastHit2D hit;
    public float maxDistance = 10f;
    public LayerMask mask;

    // Start is called before the first frame update
    //void Start()
    //{
        //joint.enabled = false;
    //}

    // Update is called once per frame
    void Update()
    {
        var worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));
        var facingDirection = worldMousePosition - transform.position;
        var aimAngle = Mathf.Atan2(facingDirection.y, facingDirection.x);
        if (aimAngle < 0f)
        {
            aimAngle = Mathf.PI * 2 + aimAngle;
        }
        if (!ropeAttached)
        {
            SetCrosshairPosition(aimAngle);
            
        }

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = 0;



     
        }

        //hit = Physics2D.Raycast(transform.position, targetPos - transform.position, maxDistance, mask);

        //if (hit.collider != null & hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
        

        
    }

    private void SetCrosshairPosition(float aimAngle)
    {
        if (!crosshairSprite.enabled)
        {
            crosshairSprite.enabled = true;
        }

        var x = transform.position.x + cursorDistance * Mathf.Cos(aimAngle);
        var y = transform.position.y + cursorDistance * Mathf.Sin(aimAngle);

        var crossHairPosition = new Vector3(x, y, 0);
        crosshair.transform.position = crossHairPosition;
    }
}
