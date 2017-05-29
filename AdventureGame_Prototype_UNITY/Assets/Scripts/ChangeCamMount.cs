using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamMount : MonoBehaviour {

    public Transform camMount;
    public GameObject camManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            camManager.gameObject.GetComponent<MenuCamControl>().currentMount = camMount;
           // camManager.transform.position = this.transform.position;
        }
        
    }
}
