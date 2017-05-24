using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingImage : MonoBehaviour {

   public bool fadeOut;
    public float speed;

	// Use this for initialization
	void Start () {
        fadeOut = true;
	}
	
	// Update is called once per frame
	void Update () {
        Color image_c = gameObject.GetComponent<Image>().color;

        if (fadeOut == true)
        {
            image_c.a -= speed * Time.deltaTime;
            gameObject.GetComponent<Image>().color = image_c;
        }

        if (fadeOut == false)
        {
            image_c.a += speed * Time.deltaTime;
            gameObject.GetComponent<Image>().color = image_c;
        }

        if (image_c.a <= 0f)
        {
            fadeOut = false;
        }

        if (image_c.a >= 1)
        {
            fadeOut = true;
        }
    }
}
