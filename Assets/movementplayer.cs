using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public Rigidbody rb;

    void FixedUpdate(){

rb.AddForce(0,0,  1000 * Time.deltaTime);
if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,  -1000 * Time.deltaTime);
        }
    
}
}
