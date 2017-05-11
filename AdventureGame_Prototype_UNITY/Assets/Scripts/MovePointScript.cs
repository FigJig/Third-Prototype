using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
            foreach (GameObject mP in movePoints)
                Destroy(mP);
        }
    }

	// Update is called once per frame
	void Update () {

	}
}
