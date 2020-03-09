using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossTopDownSeed : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject masterDoor;
    Transform tf;
    SpriteRenderer spriteRender;
    void Start()
    {
        //find best hentai don't mind me FBI
        tf = GameObject.Find("Player").GetComponent<Transform>();
        spriteRender = GameObject.Find("Player").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("Room_Tracker").GetComponent<TopDown_Check>().TopDown = true;
        if (collision.gameObject.tag == "Player")
        {
            tf.position = new Vector3(-69.88f, -26.82f, 0);
            //GameObject.Find("Player").GetComponent<Move2D>().facingRight = false;
            //spriteRender.flipX = false;
        }

    }
}
