﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 correctTarget = new Vector3(target.position.x, transform.position.y, target.position.z);

        transform.LookAt(correctTarget);

	}

}
