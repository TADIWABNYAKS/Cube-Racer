using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidCollisions : MonoBehaviour
{
    public AndroidMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Handheld.Vibrate();
            movement.enabled = false;
            
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag == "BOOST")

        {
            FindObjectOfType<PlayerMovement>().BOOST();
           
        }

        


    }

}


