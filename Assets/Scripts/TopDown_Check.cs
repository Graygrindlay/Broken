using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_Check : MonoBehaviour
{
    public bool TopDown;
    
    MoveTopDown topdownscript;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        topdownscript = GetComponent<MoveTopDown>();
        TopDown = false;
    }

    
    void Update()
    {
        

        if (TopDown == false)
        {
            GameObject.Find("Player").GetComponent<MoveTopDown>().enabled = false;
            GameObject.Find("Player").GetComponent<Move2D>().enabled = true;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale = 1;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().gravity = new vector3(0, -1);

        }
        else if (TopDown = true)
        {
            
            GameObject.Find("Player").GetComponent<Move2D>().enabled = false;
            GameObject.Find("Player").GetComponent<MoveTopDown>().enabled = true;
            GameObject.Find("Player").GetComponent<Rigidbody2D>().gravityScale = 0;
            GameObject.Find("Player").GetComponent<DashScript>().hasDashed = false;

        }


    }
}
