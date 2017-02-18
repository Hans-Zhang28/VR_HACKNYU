using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
 	public int initialScore = 0;
    public Text scoreText;
    public int time = 90;

    int currentScore;

	// Use this for initialization
	void Start () {
        currentScore = initialScore;
        //scoreText.text = "SCORE: 0";
	}

    void Update () {
        // if (time == 0) {
        //     Instantiate(alertReference, new Vector3(0.5f, 0.5f, 0), transform.rotation);
        // }
    }

	public void AddScore(int amount) {
        currentScore += amount;
        scoreText.text = "SCORE: " + currentScore;
    }
}
