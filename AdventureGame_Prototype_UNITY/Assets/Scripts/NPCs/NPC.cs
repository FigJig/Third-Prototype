using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : Interactable {

    public string[] dialogue;
    public string name;

    public GameObject npcDialogue;
    Button giveButton;
    Button declineButton;

    public Text topLeft;
    public Text topRight;

    bool hasSpoken;
    bool rotatePlayer;

    public Animator textAnim;
    public GameObject exitDoor;

    void Awake ()
    {
        giveButton = npcDialogue.transform.Find("Buttons").GetChild(0).GetComponent<Button>();
        declineButton = npcDialogue.transform.Find("Buttons").GetChild(1).GetComponent<Button>();

        giveButton.onClick.AddListener(delegate { GiveMoney(); });
        declineButton.onClick.AddListener(delegate { DeclineGiveMoney(); });
    }

    public override void Interact()
    {

        Debug.Log("Interacting with NPC.");

        if (!hasSpoken)
        {
            gameObject.GetComponent<RotatePlayer>().enabled = true;
            npcDialogue.SetActive(true);
            topLeft.text = dialogue[0];
            topRight.text = dialogue[1];
            textAnim.gameObject.GetComponent<Animator>().Play("FadeInText");
            hasSpoken = true;
            rotatePlayer = true;
        }

        if(hasSpoken)
        {
            return;
        }
    }

    public void GiveMoney()
    {
        gameObject.tag = "Untagged";
        gameObject.GetComponent<RotatePlayer>().enabled = false;
        exitDoor.gameObject.GetComponent<MoveObject>().enabled = true;
        giveButton.GetComponent<Button>().interactable = false;
        declineButton.GetComponent<Button>().interactable = false;
        topLeft.text = dialogue[2];
        topRight.text = dialogue[3];
        textAnim.gameObject.GetComponent<Animator>().Play("EndOfDialogue");

    }

    public void DeclineGiveMoney()
    {
        gameObject.tag = "Untagged";
        gameObject.GetComponent<RotatePlayer>().enabled = false;
        exitDoor.gameObject.GetComponent<MoveObject>().enabled = true;
        giveButton.GetComponent<Button>().interactable = false;
        declineButton.GetComponent<Button>().interactable = false;
        topLeft.text = dialogue[4];
        topRight.text = dialogue[5];
        textAnim.gameObject.GetComponent<Animator>().Play("EndOfDialogue");

    }
}
