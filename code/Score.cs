using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        float score = player.position.z;

        float ActualScore = score / 1.5f ;

        scoreText.text = ActualScore.ToString("0");

        if (ActualScore> PlayerPrefs.GetFloat("Highscore", 0)) {

            PlayerPrefs.SetFloat("Highscore", ActualScore);
        }
        
     
	}
}
