﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	float mousePos;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y, 0f); 
		
		mousePos = (Input.mousePosition.x / Screen.width * 16);
		print (mousePos);
		
		paddlePos.x = Mathf.Clamp(mousePos,.5f,15.5f);
		
		this.transform.position = paddlePos;
	}
}
