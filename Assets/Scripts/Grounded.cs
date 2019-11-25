using UnityEngine;



public class Grounded : MonoBehaviour
{
    GameObject Player;

    // Update is called once per frame
    
    
    void Start()
    {
        Player = gameObject.transform.parent.gameObject; 
    
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider>().tag ==("Ground"))
        {
            Player.GetComponent<DashScript>().isGrounded = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (GetComponent<Collider>().tag == ("Ground"))
        {
            Player.GetComponent<DashScript>().isGrounded = false;

        }
    }


}
