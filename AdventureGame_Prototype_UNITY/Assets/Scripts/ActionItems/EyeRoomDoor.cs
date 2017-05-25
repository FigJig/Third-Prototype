using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeRoomDoor : ActionItem {

    public Animator eyeLidsAnim;
    public GameObject player;

    public GameObject BGM;

    public override void Interact()
    {
        //base.Interact();
        Debug.Log("Door used");
        BGM.gameObject.GetComponent<FadeOutAudio>().fadeOutAudio = true;
        eyeLidsAnim.gameObject.GetComponent<Animator>().enabled = true;
        eyeLidsAnim.gameObject.GetComponent<Animator>().Play("UI_EyeLidClosing");
        player.gameObject.GetComponent<WorldInteraction>().enabled = false;
        player.gameObject.GetComponent<MovePlayerObject>().enabled = true;
    }

}
