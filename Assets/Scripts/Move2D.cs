using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Move2D : MonoBehaviour
{
    public float movespeed = 5f;
    

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0 ,0);

        transform.position += movement * Time.deltaTime * movespeed;



    }

   


}
