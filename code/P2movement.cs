using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2movement : MonoBehaviour {
    public Rigidbody rb;
    bool Jump = true;

    public float forwardForce = 4550f;
    public float sidewaysForce = 120f;
    public float jumpForce = 0f;

    void FixedUpdate()
    {

        if (Input.GetKey("o"))
        {
            while(Jump == true)
            {
                rb.AddForce(50 * Time.deltaTime, 0, 0);
                //Debug.Log("Player has jumped")
                Jump = false;
            }
            Jump = true;   
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("j"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("l"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("i"))                       // CURRENTLY NOT IN GAME AS NEED FOR TESTING AND BALACNCING IS NEEDED 
        {
            rb.AddForce(0, -jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("k"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}


