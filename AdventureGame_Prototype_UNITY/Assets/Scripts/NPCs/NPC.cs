using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : Interactable {

    public string[] dialogue;
    public string name;

    public GameObject npcDialogue;
    public GameObject buttons;
    Button giveButton;
    Button declineButton;

    public GameObject topLeftText;

    public Text topLeft;
    public Transform middle;
    public Text topRight;

    bool hasSpoken;
    bool rotatePlayer;

    public GameObject cameraControl;
    public Transform[] mount;

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
            cameraControl.gameObject.GetComponent<MenuCamControl>().currentMount = mount[1];
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
       // cameraControl.gameObject.GetComponent<MenuCamControl>().speedFactor = 0.03f;
        gameObject.tag = "Untagged";
        gameObject.GetComponent<RotatePlayer>().enabled = false;
        exitDoor.gameObject.GetComponent<MoveObject>().enabled = true;
        buttons.SetActive(false);
        giveButton.GetComponent<Button>().interactable = false;
        declineButton.GetComponent<Button>().interactable = false;
        topLeft.text = dialogue[2];
        topRight.text = dialogue[3];
        textAnim.gameObject.GetComponent<Animator>().Play("EndOfDialogue");
        cameraControl.gameObject.GetComponent<MenuCamControl>().currentMount = mount[0];
    }

    public void DeclineGiveMoney()
    {
        // cameraControl.gameObject.GetComponent<MenuCamControl>().speedFactor = 0.03f;
        topLeftText.transform.position = middle.position;
        gameObject.tag = "Untagged";
        gameObject.GetComponent<RotatePlayer>().enabled = false;
        exitDoor.gameObject.GetComponent<MoveObject>().enabled = true;
        buttons.SetActive(false);
        giveButton.GetComponent<Button>().interactable = false;
        declineButton.GetComponent<Button>().interactable = false;
        topLeft.text = dialogue[4];
        topRight.text = dialogue[5];
        textAnim.gameObject.GetComponent<Animator>().Play("EndOfDialogue");
        cameraControl.gameObject.GetComponent<MenuCamControl>().currentMount = mount[0];
    }
}
