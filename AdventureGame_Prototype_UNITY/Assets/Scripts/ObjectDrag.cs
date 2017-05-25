using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 itemSlotPos;
    public bool itemSlotFound;

    public Transform originPos;
    public Text text;
    public string itemText;

    public AudioSource sceneAS;
    public AudioClip itemSound;

    GameObject itemSpot;
    public GameObject suitcase;

    void Start()
    {
        itemSlotFound = false;
        suitcase.gameObject.GetComponent<PackingControlScript>();

    }

    // Use this for initialization
    void OnMouseDown()
    {
      
        Debug.Log("Interactable object hit");
        //gameObject.GetComponent<BoxCollider>().isTrigger = false;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        if (itemSlotFound == true)
        {
            itemSpot.gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        itemSlotFound = false;
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
            //Vector3 position = transform.position;
           // position.y -= 5;
            transform.position = originPos.position;
        }

        if (itemSlotFound == true)
        {
            transform.position = itemSlotPos;
            text.gameObject.GetComponent<Text>().text = itemText;
           // itemSpot.gameObject.tag = "ItemPlaced";
            itemSpot.gameObject.GetComponent<BoxCollider>().enabled = false;
            sceneAS.gameObject.GetComponent<AudioSource>().clip = itemSound;
            sceneAS.gameObject.GetComponent<AudioSource>().PlayOneShot(sceneAS.gameObject.GetComponent<AudioSource>().clip);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ItemSlot")
        {
            Debug.Log("In item slot");
            itemSlotPos = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            itemSlotFound = true;
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
            itemSpot = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ItemSlot")
        {
            itemSlotFound = false;
            Debug.Log("In item slot");
            transform.position = other.transform.position;
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
           // itemSpot = null;
        }
    }
}
