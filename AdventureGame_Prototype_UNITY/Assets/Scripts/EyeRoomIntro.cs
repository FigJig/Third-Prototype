using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeRoomIntro : MonoBehaviour {

    public GameObject fadeOut;

    bool fadeOutFinish = false;
    float coolDown = 1.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        coolDown -= Time.deltaTime;

        if (fadeOutFinish == false & coolDown <= 0f)
        {
            Color fadeOut_c = fadeOut.gameObject.GetComponent<Image>().color;
            fadeOut_c.a -= 0.3f * Time.deltaTime;
            fadeOut.gameObject.GetComponent<Image>().color = fadeOut_c;

            if (fadeOut_c.a <= 0f)
            {
                coolDown = 0f;
                Destroy(fadeOut);
                fadeOutFinish = true;
                gameObject.GetComponent<EyeRoomIntro>().enabled = false;
            }
        }
    }
}
