﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    public float destroyTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroyTime -= Time.deltaTime;
		if (destroyTime < 0)
        {
            Destroy(gameObject);
        }
	}
}
