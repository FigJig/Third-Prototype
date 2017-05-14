using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeRoomDoor : ActionItem {

    public Animator eyeLidsAnim;
    public GameObject player;

public override void Interact()
    {
        base.Interact();
        Debug.Log("Door used");
        eyeLidsAnim.gameObject.GetComponent<Animator>().Play("EyeShut");
        player.gameObject.GetComponent<WorldInteraction>().enabled = false;
        player.gameObject.GetComponent<MovePlayerObject>().enabled = true;
    }

}
