﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour {

    public GameObject movePoint;

    NavMeshAgent playerAgent;

	// Use this for initialization
	void Start () {
        playerAgent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            GetInteraction();
        }
    }

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;

        if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;

            if(interactedObject.tag == "Interactable Object")
            {
                Debug.Log("Interactable object hit");
                GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
                foreach (GameObject mP in movePoints)
                    Destroy(mP);
                Instantiate(movePoint, interactionInfo.point, Quaternion.identity);
               
                interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
            }

            if (interactedObject.tag == "Wall")
            {
                Debug.Log("Wall hit");
                playerAgent.destination = interactionInfo.point;
                GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
                foreach (GameObject mP in movePoints)
                    Destroy(mP);
            }

            if (interactedObject.tag == "Ground")
            {
                Debug.Log("Just walking");
                playerAgent.stoppingDistance = 0;
                playerAgent.destination = interactionInfo.point;
                Debug.DrawLine(transform.position, interactionInfo.point, Color.red);
                GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
                foreach (GameObject mP in movePoints)
                    Destroy(mP);
                Instantiate(movePoint, interactionInfo.point, Quaternion.identity);
            }
        }
    }
}