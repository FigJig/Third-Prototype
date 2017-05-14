using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour {

    public Transform player;

	// Update is called once per frame
	void Update () {

            Vector3 targetDir = transform.position - player.transform.position;
            float step = 1 * Time.deltaTime;
            Vector3 newDir = Vector3.RotateTowards(player.transform.forward, targetDir, step, 0.0F);
            Debug.DrawRay(player.transform.position, newDir, Color.red);
            player.transform.rotation = Quaternion.LookRotation(newDir);
        
    }
}
