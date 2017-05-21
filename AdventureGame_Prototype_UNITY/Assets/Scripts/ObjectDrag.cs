using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 itemSlotPos;
    public bool itemSlotFound;

    public Text text;
    public string itemText;

    void Start()
    {
        itemSlotFound = false;
    }

    // Use this for initialization
    void OnMouseDown()
    {
        itemSlotFound = false;
        Debug.Log("Interactable object hit");
        //gameObject.GetComponent<BoxCollider>().isTrigger = false;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z - 5);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        //gameObject.GetComponent<BoxCollider>().isTrigger = true;
        if (itemSlotFound == false)
        {
            Vector3 position = transform.position;
            position.y -= 5;
            transform.position = position;
        }

        if (itemSlotFound == true)
        {
            transform.position = itemSlotPos;
            text.gameObject.GetComponent<Text>().text = itemText;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ItemSlot")
        {
            Debug.Log("In item slot");
            Vector3 itemSlotPos = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            itemSlotFound = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ItemSlot")
        {
            itemSlotFound = false;
            Debug.Log("In item slot");
            transform.position = other.transform.position;
        }
    }
}
