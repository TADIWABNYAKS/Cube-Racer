using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuMusic : MonoBehaviour
{


    public GameObject Music;

   public  void update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("LEVELS"))
        {
            DontDestroyOnLoad(Music);
        }



    }
}
    

