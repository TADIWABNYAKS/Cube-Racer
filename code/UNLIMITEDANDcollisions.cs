using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNLIMITEDANDcollisions : MonoBehaviour
{
   
   
        public UNLIMITEDANDM movement;

        void OnCollisionEnter(Collision collisionInfo)
        {

            if (collisionInfo.collider.tag == "Obstacle")
            {
                movement.enabled = false;
                FindObjectOfType<UnlimitedGameManager>().EndGame();
            Handheld.Vibrate();
        }
        }

    }



