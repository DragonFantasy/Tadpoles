using UnityEngine;
using System.Collections;

public class GameInput : MonoBehaviour 
{
	Vector3 moveVec = new Vector3();
	public float movePerUpdate;

	//get offset of object moving
	//for mobile device use acelorator
	//for pc use keyboard
	public Vector3 GetInputMove()
	{
		moveVec = Vector3.zero;
#if UNITY_IPHONE || UNITY_ANDROID || UNITY_WP8 || UNITY_WINRT
		moveVec.x += Input.acceleration.x * movePerUpdate;
		//moveVec.y += -Input.acceleration.y * movePerUpdate;
#else
		//left
		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			moveVec.x -= movePerUpdate;
		}
		//right
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			moveVec.x += movePerUpdate;
		}
		/*
		//up
		if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			moveVec.y += movePerUpdate;
		}
		//down
		if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			moveVec.y -= movePerUpdate;
		}*/
#endif
		return moveVec;
	}
}
