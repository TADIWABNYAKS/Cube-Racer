using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HIGHSCORE : MonoBehaviour {

    public Text scoreHigh;


    void Update()
    {
        scoreHigh.text = PlayerPrefs.GetFloat("Highscore", 0).ToString("0");
    }
}
