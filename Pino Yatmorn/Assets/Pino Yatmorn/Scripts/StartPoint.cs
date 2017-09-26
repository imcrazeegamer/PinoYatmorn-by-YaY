using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour {

    PinoMovement thePlayer;
    CameraFollowPino theCamera;
	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<PinoMovement>();
        thePlayer.transform.position = new Vector3(transform.position.x, transform.position.y, thePlayer.transform.position.z); ;

        theCamera = FindObjectOfType<CameraFollowPino>();
        theCamera.transform.position = new Vector3 (transform.position.x,transform.position.y,theCamera.transform.position.z);
	}
	
}
