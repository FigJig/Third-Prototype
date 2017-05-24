using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAudio : MonoBehaviour {

    AudioSource audio;

    public float audioLevel;

	// Use this for initialization
	void Start () {
        audio = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audio.volume += 0.1f * Time.deltaTime;

        if (audio.volume >= audioLevel)
        {
            gameObject.GetComponent<FadeAudio>().enabled = false;
        }
	}
}
