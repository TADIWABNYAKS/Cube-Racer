using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6collision : MonoBehaviour {
    public Level6movement movement;
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

