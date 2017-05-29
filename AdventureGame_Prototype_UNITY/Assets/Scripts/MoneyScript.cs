using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour {

    public GameObject suitcase;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<ObjectDrag>().itemSlotFound == true)
        {
            suitcase.gameObject.GetComponent<PackingControlScript>().moneyPlaced = true;
        }

        else
        {
            suitcase.gameObject.GetComponent<PackingControlScript>().moneyPlaced = false;
        }
	}
}
