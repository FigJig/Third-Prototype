using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackingControlScript : MonoBehaviour {

    public bool[] itemsPacked;

    public GameObject[] itemSlot;
    public GameObject closeSuitcase;
    public GameObject flashingImages;
    public GameObject mainCanvas;

    Animator suitcaseAnim;

	// Use this for initialization
	void Start () {
        suitcaseAnim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if (itemsPacked[0] == true & itemsPacked[1] == true & itemsPacked[2] == true & itemsPacked[3] == true & itemsPacked[4] == true & itemsPacked[5] == true)
        {
            closeSuitcase.SetActive(true);
        }

        else
        {
            closeSuitcase.SetActive(false);
        }

        if (itemSlot[0].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[0] = true;
        }

        if (itemSlot[0].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[0] = false;
        }

        if (itemSlot[1].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[1] = true;
        }

        if (itemSlot[1].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[1] = false;
        }

        if (itemSlot[2].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[2] = true;
        }

        if (itemSlot[2].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[2] = false;
        }

        if (itemSlot[3].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[3] = true;
        }

        if (itemSlot[3].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[3] = false;
        }

        if (itemSlot[4].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[4] = true;
        }

        if (itemSlot[4].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[4] = false;
        }

        if (itemSlot[5].gameObject.GetComponent<BoxCollider>().enabled == false)
        {
            itemsPacked[5] = true;
        }

        if (itemSlot[5].gameObject.GetComponent<BoxCollider>().enabled == true)
        {
            itemsPacked[5] = false;
        }
    }

    public void CloseSuitcase()
    {
        flashingImages.SetActive(false);
        suitcaseAnim.Play("Suitcase_Closing");
        mainCanvas.SetActive(true);
        mainCanvas.gameObject.GetComponent<FadeInOutImage>().fadeOutFinish = true;
    }
}
