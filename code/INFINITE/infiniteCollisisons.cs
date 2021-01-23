using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteCollisisons : MonoBehaviour
{


    public UNLIMITEDMOVEMENT movement;
    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Handheld.Vibrate();
            FindObjectOfType<UnlimitedGameManager>().EndGame();
        }
    }
}