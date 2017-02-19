using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    private int score = 0;
    public float time = 90;
	bool gameStarted = false;
    public Text scoreText;
    public Text timeText;

	// Use this for initialization
	void Start () {
		gameStarted = true;
	}

    void Update () {
        if (time > 0)
        {
            time -= Time.deltaTime;
        } else
        {
            time = 0;
        }
        timeText.text = "TIME: " + time.ToString();
    }

    public void addScore()
    {
        score++;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
