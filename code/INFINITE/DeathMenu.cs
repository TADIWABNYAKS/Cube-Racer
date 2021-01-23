using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class DeathMenu : MonoBehaviour
{
    public void Resart()
        {

        SceneManager.LoadScene("UNLIMITED");

    }

    public void Quit()
    {

        SceneManager.LoadScene("STARTSCREEN");

    }














}