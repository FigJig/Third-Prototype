using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeLoadLevel : MonoBehaviour {

    public Image fadeImage;
	
    void Start()
    {
        
    }

	// Update is called once per frame
	void Update () {
        Color fadeImage_c = fadeImage.gameObject.GetComponent<Image>().color;
        fadeImage_c.a += 0.45f * Time.deltaTime;
        fadeImage.gameObject.GetComponent<Image>().color = fadeImage_c;

        if (fadeImage_c.a >= 1f)
        {
            SceneManager.LoadScene("EyeRoomScene");
        }
    }
}
