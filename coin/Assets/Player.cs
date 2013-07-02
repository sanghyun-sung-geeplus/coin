using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	
	public float speed = 6.0f;
	public float jumpSpeed  = 8.0f;
	public float gravity  = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//地面についているかどうか
		if (!controller.isGrounded) {
			//移動方向を取得
			
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetKey("w")?10:0);
			
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			
			//ジャンプ
			//if (Input.GetButton("Jump"))
			{
				//moveDirection.y = jumpSpeed;
			}
		}
		// 重力を計算
		moveDirection.y -= gravity * Time.deltaTime;
		// 移動
		controller.Move(moveDirection * Time.deltaTime);
		Debug.Log((gravity * Time.deltaTime).ToString());
	}
}
