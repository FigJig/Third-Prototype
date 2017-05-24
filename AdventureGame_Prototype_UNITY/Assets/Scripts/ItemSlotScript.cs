using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlotScript : MonoBehaviour {

    public GameObject suitcase;

    void Start()
    {
        suitcase.gameObject.GetComponent<PackingControlScript>();
    }

    void Update()
    {

    }
}
