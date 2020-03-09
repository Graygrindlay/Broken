using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class Flicker : MonoBehaviour
{
    float duration = 1.0f;
    Color color0 = Color.red;
    Color color1 = Color.blue;


    float random;

    Light2D lt;
    
    
    void Start()
    {
        lt = GetComponent<Light2D>();
        
       
    }
}
