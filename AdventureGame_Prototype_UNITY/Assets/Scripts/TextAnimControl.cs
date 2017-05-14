﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnimControl : MonoBehaviour {

    public GameObject npcDialogue;

    public void Activate()
    {
        npcDialogue.transform.FindChild("Buttons").GetComponent<Animator>().Play("EyeLevel_FadeInButtons");
    }

    public void FadeOutButtons()
    {
        npcDialogue.transform.FindChild("Buttons").GetComponent<Animator>().Play("EyeLevel_FadeOutButtons");
    }


    public void Disable()
    {
        npcDialogue.SetActive(false);
    }

}