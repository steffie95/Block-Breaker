﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start () {

		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print (paddleToBallVector);
	}


	
	// Update is called once per frame
	void Update () {
		if(!hasStarted){
		this.transform.position = paddle.transform.position + paddleToBallVector;
		
		if(Input.GetMouseButtonDown(0)){
			print ("Mouse clicked, launch ball");
			hasStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);
		}
	}

		

	
	}
	void OnColissionEnter2D (Collision2D Collision){
	Vector2 tweak = new Vector2(Random.Range (0f, 0.2f), Random.Range (0f, 0.2f));

	if (hasStarted){
	//rigidbody2D.velocity += tweak;
	}
	}
}
