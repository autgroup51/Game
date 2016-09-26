using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


    public Transform target;
    Camera mycam;
	
    //Get the Camera component
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	
	void Update () {
        //Camera size show on the screen will be denpends on the Screen size for user friendly reason
        mycam.orthographicSize = (Screen.height / 100f) / 1f;
        //The target will be set as player and make the camera follow the play.
        if (target)
        {

            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
        }
	}
}
