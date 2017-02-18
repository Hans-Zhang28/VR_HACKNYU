using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
 	public int initialScore = 0;
    public Text scoreText;
	bool gameStarted = false;

    int currentScore;
	int maxScore;

	// Use this for initialization
	void Start () {
		gameStarted = true;
	}

    void Update () {
    }
}
