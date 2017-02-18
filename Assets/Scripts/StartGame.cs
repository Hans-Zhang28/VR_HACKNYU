using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
    public FoodManager spawner;
    private GameManager gm;
    // private GUIText timeTF;
	// Use this for initialization
	void Start () {
		// timeTF = gameObject.guiText;
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
   		InvokeRepeating("ReduceTime", 1, 1);
    }
	
	// Update is called once per frame
	void ReduceTime() {
		gm = GameObject.Find("GameManager").GetComponent<GameManager>();
		if (gm.time == 1) {
	        Time.timeScale = 0;
	        // just comment out first in case the music is not controlled by timer
	        // audio.Play();
	        // GameObject.Find("AppleGUI").GetComponent<AudioSource>().Stop();
	    }
	    gm.time = gm.time - 1;
	    // timeTF.text = (gm.time).ToString();
	}

    private void OnCollisionEnter (Collision other)  {
       spawner.enabled = true;
    }
}
