using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonsL6and : MonoBehaviour
{
    public Level6and movement;
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            Handheld.Vibrate();
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }

}

