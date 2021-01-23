using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Level6movement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 4000f;
    float sidewaysForce = 784f;
    public float jumpForce = 0f;

    public void Main(string[] args)
    {
        ThreadStart = childref = new ThreadStart(CallToChildThread);
        debug.log("Child thread created");

        ThreadEnd = childref = new ThreadEnd(CallToChildThread);
        debug.log("Child thread ended");
        Thread.Sleep(30000);


    }


    void FixedUpdate()
    {

        
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {

           // transform.position += forwardForce * Time.deltaTime ForceMode.VelocityChange;

            // rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, For ceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))                       // FOR TESTING LEVELS ONLY GAME IMPLEMENTATION IS UNKNOWN 

        {
            rb.AddForce(0, -jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.positiony < 70.5f)
        {
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}

