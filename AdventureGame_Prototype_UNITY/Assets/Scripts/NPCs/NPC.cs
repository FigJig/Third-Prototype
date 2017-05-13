using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {

    public Animator eyeLidsAnim;

    public Transform player;

    public override void Interact()
    {
        Debug.Log("Interacting with NPC.");
        //player.transform.LookAt(this.transform.position);
        eyeLidsAnim.gameObject.GetComponent<Animator>().Play("EyeShut");
    }

}
