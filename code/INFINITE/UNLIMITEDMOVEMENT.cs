using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UNLIMITEDMOVEMENT : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 4550f;
    public float sidewaysForce = 120f;
    public float jumpForce = 0f;



   











    public void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
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
        if (rb.position.y < -1f)
        {

            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
            FindObjectOfType<UnlimitedGameManager>().EndGame();
        }
    }
}

( )