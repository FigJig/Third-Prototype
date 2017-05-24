using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutAudio : MonoBehaviour {

    public AudioSource audio;

    public float speed;

    public bool fadeOutAudio;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (fadeOutAudio == true)
        {
            DontDestroyOnLoad(audio.transform.gameObject);
            audio.gameObject.GetComponent<AudioSource>().volume -= speed * Time.deltaTime;

            if (audio.gameObject.GetComponent<AudioSource>().volume <= 0f)
            {
                Destroy(gameObject);
            }
        }
    }

    public void fadeAudio()
    {
        fadeOutAudio = true;
    }
}
