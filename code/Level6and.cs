using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6and: MonoBehaviour
{

    public Rigidbody rb;

    float forwardForce = 2950f;
    float sidewaysForce = 850f;
     float jumpForce = 0f;

    private float screenCenterX;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    private void Update()
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

    

        if (rb.position.y < 70.5f)
        {
            
            FindObjectOfType<GameManager>().EndGame();
            Handheld.Vibrate();
        }
    }
}
