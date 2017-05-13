using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeRoomDoor : ActionItem {

public override void Interact()
    {
        base.Interact();
        Debug.Log("Door used");
    }
}
