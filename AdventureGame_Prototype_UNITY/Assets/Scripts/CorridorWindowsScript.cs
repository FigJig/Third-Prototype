using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorWindowsScript : MonoBehaviour {

    public Transform lightSpot;
    public GameObject lightObject;
    public AudioClip lightAudio;

    AudioSource lightAS;

    void Start ()
    {
        lightAS = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            lightObject.transform.position = lightSpot.transform.position;
            lightAS.clip = lightAudio;
            lightAS.PlayOneShot(lightAS.clip);
        }
    }
}
