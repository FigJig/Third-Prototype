using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
    [SerializeField]
    [Range(1, 20)]
    private float speed = 10;

    NavMeshAgent nav;

    public GameObject movePoint;

    private Vector3 targetPosition;
    private bool isMoving;

    const int LEFT_MOUSE_BUTTON = 0;

	// Use this for initialization
	void Start () {
        targetPosition = transform.position;
        isMoving = false;
        nav = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(LEFT_MOUSE_BUTTON))
            SetTargetPosition();

        if (isMoving)
            MovePlayer();

	}

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "MovePoint")
        {
            GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
            foreach (GameObject mP in movePoints)
                Destroy(mP);
            //Debug.Log("Hit");
        }

        if (other.gameObject.tag == "Wall")
        {
            isMoving = false;
        }

        if (other.gameObject.tag == "NPC")
        {
            isMoving = false;
        }
    }

    void SetTargetPosition()
    {
        Plane plane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0f;

        if (plane.Raycast(ray, out point))
        {
            targetPosition = ray.GetPoint(point);
            GameObject[] movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
            foreach (GameObject mP in movePoints)
                Destroy(mP);
            Instantiate(movePoint, targetPosition, Quaternion.identity);
        }

        isMoving = true;
    }

    void MovePlayer()
    {
        transform.LookAt(targetPosition);
        nav.SetDestination(targetPosition);
        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
            isMoving = false;

        Debug.DrawLine(transform.position, targetPosition, Color.red);
    }
}
