using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move_script : MonoBehaviour {
	public float dampTime = 0.15f;
	public float camSpeed = 1.0f;
	private Vector3 velocity = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (key: KeyCode.LeftArrow)) {
			Vector3 destination = transform.position + new Vector3(-1.0f * camSpeed, 0.0f, 0.0f);
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		if (Input.GetKey (key: KeyCode.RightArrow)) {
			Vector3 destination = transform.position + new Vector3(camSpeed, 0.0f, 0.0f);
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
