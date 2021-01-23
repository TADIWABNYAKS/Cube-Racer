using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class MainMenu : MonoBehaviour
{
    public void START()
    {
        SceneManager.LoadScene("DIFFICULTY");
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

    public void UNLIMITED()
    {
        SceneManager.LoadScene("UNLIMITED");
    } 

    public void Credit()
    {
        SceneManager.LoadScene("CREDITS");
    }

    public void EASY()
    {

       
        SceneManager.LoadScene("LEVELSEASY");
    }

    public void Hard()
    {
        
        SceneManager.LoadScene("LEVELS");
    }

    public void HowTo()
    {
        SceneManager.LoadScene("HowTo");

    }
}
