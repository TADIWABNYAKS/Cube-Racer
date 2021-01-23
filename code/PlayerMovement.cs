using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	
	public Rigidbody rb;

	public float forwardForce = 4550f;	
	public float sidewaysForce = 120f;
    public float jumpForce = 0f;
    public float boostSpeed = 8000f;
    public int SecondsOfBoost = 4;


    void FixedUpdate()
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
            rb.AddForce(0,-jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
          {
             rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
         }
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}

        

    }


    public void BOOST()// FUTURE STUFF
    {
        rb.AddForce(0, boostSpeed * Time.deltaTime, 0);
        FixedUpdate();
    }

 
}




    