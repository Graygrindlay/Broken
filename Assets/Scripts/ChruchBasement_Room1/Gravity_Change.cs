using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(1f, 0, -9.81f);
    }
}
