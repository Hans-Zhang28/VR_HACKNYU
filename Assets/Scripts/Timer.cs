// using UnityEngine;
// using System.Collections;
// using UnityEngine.UI;

// public class Timer : MonoBehaviour {
// 	private Text timeTF;
// 	public GameObject alertReference;

// 	// Use this for initialization
// 	void Start () {
//  		timeTF = gameObject.GetComponent<GUIText>();
//    		InvokeRepeating("ReduceTime", 1, 1);
// 	}

// 	void ReduceTime() {
// 		if (timeTF.text == "1") {
// 	        Time.timeScale = 0;
// 	        Instantiate(alertReference, new Vector3(0.5f, 0.5f, 0), transform.rotation);
// 	        // just comment out first in case the music is not controlled by timer
// 	        // audio.Play();
// 	        // GameObject.Find("AppleGUI").GetComponent<AudioSource>().Stop();
// 	    }
		     
// 	    timeTF.text = (int.Parse(timeTF.text) - 1).ToString();
// 	}
	
// 	// this may need to be removed since the we may not need to setup levels
// 	void Reload () {
// 		Application.LoadLevel (Application.loadedLevel);
// 	}
// }
