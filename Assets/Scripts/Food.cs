﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	void OnCollisionEnter (Collision collision)
	{
		if (collision.collider.tag == "Floor")
		{
			Destroy (gameObject, Random.Range(0,3));
		}
	}
}
