﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public static int Screen_Height;
	public static int Screen_Width;

	public UISprite playerTadpole;
	public GameInput input;

	// Use this for initialization
	void Start () 
	{
		Screen_Height = Screen.height;
		Screen_Width = Screen.width;
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerTadpole.transform.localPosition += input.GetInputMove();
	}
}
