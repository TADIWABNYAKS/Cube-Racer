using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNLIMITEDANDM : MonoBehaviour
{




    public Rigidbody rb;

     float forwardForce = 3000f;
     float sidewaysForce = 700f;
     float jumpForce = 200f;
    bool GameOn = false;
    private float screenCenterX;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    public  void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // if there are any touches currently
        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    // if the touch position is to the right of center
                    // move right
                }
                else if (firstTouch.position.x < screenCenterX)
                {


                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    // if the touch position is to the left of center
                    // move left
                }

                if (firstTouch.position.y > 2f)
                {
                    rb.AddForce(jumpForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                else if (firstTouch.position.y < 2f)
                {
                    rb.AddForce(-jumpForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }

        }

        if (rb.position.y < -1f)
        {
            {
                Handheld.Vibrate();
                rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
                FindObjectOfType<UnlimitedGameManager>().EndGame();
            }
        }
        else if ( rb.position.y > 1f)
        {
            GameOn = true;
        }
    }   
}
