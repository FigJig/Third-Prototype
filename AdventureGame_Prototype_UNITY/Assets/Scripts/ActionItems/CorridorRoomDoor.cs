using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorRoomDoor : ActionItem
{
    //public Animator eyeLidsAnim;
    public GameObject player;
    public GameObject door;
    public GameObject BGM;
    public GameObject fadeImage;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public override void Interact()
    {
        Debug.Log("Door used");
        BGM.gameObject.GetComponent<FadeOutAudio>().fadeOutAudio = true;
        player.gameObject.GetComponent<WorldInteraction>().enabled = false;
        player.gameObject.GetComponent<MovePlayerObject>().enabled = true;
        door.gameObject.GetComponent<MoveObject>().enabled = true;
        fadeImage.SetActive(true);
    }
}
