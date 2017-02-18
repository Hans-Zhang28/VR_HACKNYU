using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {
	public GameObject [] foods;
	public Transform [] spawnPoints;

	public int itemsToDrop = 100;
	public float dropDelay = 1f;
	public float currentTime = 0f;
	private bool droppingItems = false;

	// Use this for initialization
	void Start () {
		currentTime = dropDelay;
		droppingItems = true;
		dropItems ();
	}
	
	// Update is called once per frame
	void Update () {
		if (droppingItems && currentTime >= 0) {
			currentTime -= Time.deltaTime;
		}
	}

	void dropItems() {
		while (itemsToDrop > 0) {
			if (currentTime < 0) {
				makeItem (foods [Random.Range (0, foods.Length)]);
				currentTime = dropDelay;
				itemsToDrop--;
			}
		}
		droppingItems = false;
	}

	void makeItem(GameObject item) {
		Vector3 pos = spawnPoints [Random.Range (0, spawnPoints.Length)].position;
		GameObject newItem = Instantiate (item, pos, Quaternion.identity);
		//newItem.GetComponent<Transform>().position = pos;
	}
}
