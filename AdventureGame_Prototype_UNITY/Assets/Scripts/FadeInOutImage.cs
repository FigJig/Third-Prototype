using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeInOutImage : MonoBehaviour {

    public GameObject fadeInOut;
    public AudioSource BGM;

    public bool fadeOutFinish = false;
    float coolDown = 1.2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coolDown -= Time.deltaTime;

        if (fadeOutFinish == false & coolDown <= 0f)
        {
            Color fadeInOut_c = fadeInOut.gameObject.GetComponent<Image>().color;
            fadeInOut_c.a -= 0.3f * Time.deltaTime;
            fadeInOut.gameObject.GetComponent<Image>().color = fadeInOut_c;

            if (fadeInOut_c.a <= 0f)
            {
                coolDown = 0f;
                fadeOutFinish = true;
                gameObject.SetActive(false);
            }
        }

        if (fadeOutFinish == true)
        {
            Color fadeInOut_c = fadeInOut.gameObject.GetComponent<Image>().color;
            fadeInOut_c.a += 0.21f * Time.deltaTime;
            fadeInOut.gameObject.GetComponent<Image>().color = fadeInOut_c;
            BGM.gameObject.GetComponent<AudioSource>().volume -= 0.1f * Time.deltaTime;

            if (fadeInOut_c.a >= 1f)
            {
                SceneManager.LoadScene("CorridorScene");
            }
        }
    }
}
