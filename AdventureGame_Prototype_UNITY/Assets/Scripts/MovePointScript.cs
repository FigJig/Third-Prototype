﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
    

    }
	

	// Update is called once per frame
	void Update () {

        Color mP_c = gameObject.GetComponent<Renderer>().material.color;
        mP_c.a -= 0.5f * Time.deltaTime;
        gameObject.GetComponent<Renderer>().material.color = mP_c;

    }
}
