using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {
	public GameObject [] foods;
	public Transform [] spawnPoints;

	public int itemsToDrop = 100;
	public float dropDelay = 1f;
	public float currentTime = 0f;

	// Use this for initialization
	void Start () {
		currentTime = dropDelay;
	}
	
	// Update is called once per frame
	void Update () {
		if (itemsToDrop > 0) {
			if (currentTime >= 0) {
				currentTime -= Time.deltaTime;
			} else {
				makeItem (foods [Random.Range (0, foods.Length)]);
				currentTime = dropDelay;
				itemsToDrop--;
			}
		}
	}

	void makeItem(GameObject item) {
		Vector3 pos = spawnPoints [Random.Range (0, spawnPoints.Length)].position;
		GameObject newItem = Instantiate (item, pos, Random.rotation) as GameObject;
		Vector3 force = new Vector3 (Random.Range (0, 100), Random.Range (0, 100), Random.Range (0, 100));
		newItem.GetComponent<Rigidbody>().AddForce(force);
	}
}
