﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRightL : MonoBehaviour 
{
	public float speed = 1.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//This moves our object left and right via player input.
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
	}
}