using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    private GameManager gameManager;
    public GameObject [] explosionPrefabs;
    private bool touched = false;
	// Use this for inidFltialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.tag == "Floor") {
            Destroy(gameObject, Random.Range(0, 3));
		} else if (collision.collider.tag == "Hand") {
			GetComponent<Transform>().SetParent (collision.gameObject.transform);
            Instantiate(explosionPrefabs[Random.Range(0, explosionPrefabs.Length)], transform.position, Quaternion.identity);
            if (!touched)
            {
                touched = true;
                gameManager.addScore();
            }
		}
	}
}
