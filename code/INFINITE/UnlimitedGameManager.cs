using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlimitedGameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 3f;

    public GameObject completeLevelUI;


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            

            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }

   
   
    void Restart()
    {
        completeLevelUI.SetActive(true);
    }
}