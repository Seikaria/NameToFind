﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Collision with " + coll.gameObject.name);
        if (coll.gameObject.name.Equals("Enemy"))
        {
            Destroy(coll.gameObject);
        }
    }
}
