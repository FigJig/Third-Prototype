using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public Transform targetPosition;
    public GameObject enableGameObject;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);

        if (transform.position == targetPosition.position)
        {
            enableGameObject.SetActive(true);
            Destroy(gameObject);
        }
	}
}
