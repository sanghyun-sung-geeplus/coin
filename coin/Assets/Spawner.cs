using UnityEngine;
using System.Collections;



public class Spawner : MonoBehaviour {
	
	public Transform prefab;
	
	enum MOUSE_BUTTON{
		eLEFT = 0,	
		eRIGHT = 1,
		eMIDDLE = 2,
	};

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
/**
static function GetMouseButtonDown (button : int) : boolean
Description
Returns true during the frame the user pressed the given mouse button.

You need to call this function from the Update function, since the state gets reset each frame. It will not return true until the user has released the mouse button and pressed it again. button values are 0 for left button, 1 for right button, 2 for the middle button.
*/
		if (Input.GetMouseButtonUp ((int)MOUSE_BUTTON.eLEFT)) {
			Vector3 offset = new Vector3(Mathf.Sin (Time.time * 7f), 0f, 0f);
        	Instantiate (prefab, transform.position + offset, transform.rotation);
			//Score.score -= 1;
			//Debug.Log("Pressed left click. Score:" + Score.score);			
    	}
		
		if (Input.GetButtonDown("Fire1") ) {
			Vector3 offset = new Vector3(Mathf.Sin (Time.time * 7f), 0f, 0f);
        	Instantiate (prefab, transform.position + offset, transform.rotation);
		}
	}
}
