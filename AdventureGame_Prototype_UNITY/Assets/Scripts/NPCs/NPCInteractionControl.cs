using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCInteractionControl : MonoBehaviour {

    //public GameObject talkToNPCButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void enableCollider(Collider npcInteractionCollider)
    {
        npcInteractionCollider.enabled = true;

    }
       // void OnTriggerEnter(Collider other)
    //{
       // if (other.gameObject.tag == "Player")
       // {
         //   talkToNPCButton.SetActive(true);
       // }
    //}
}
