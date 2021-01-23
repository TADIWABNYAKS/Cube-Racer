using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class Credits : MonoBehaviour {

  public void  Quit()
    {
        
        Application.Quit();
        Debug.Log("QUIT");

    }

    public void MENU()
    {

        SceneManager.LoadScene("STARTSCREEN");
    }
}
