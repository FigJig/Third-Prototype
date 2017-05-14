using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerObject : MonoBehaviour {

    public Transform targetPosition;
    public GameObject enableGameObject;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);

        Vector3 targetDir = targetPosition.position - transform.position;
        float step = speed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        Debug.DrawRay(transform.position, newDir, Color.red);
        transform.rotation = Quaternion.LookRotation(newDir);

    }
}
