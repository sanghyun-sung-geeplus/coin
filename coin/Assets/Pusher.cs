using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
	
	public Vector3 origin;
	
	// Use this for initialization
	void Awake () {
		origin = rigidbody.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 offset = new Vector3(0f, 0f, Mathf.Sin (Time.time));
		rigidbody.MovePosition(origin + offset);
	}
}
