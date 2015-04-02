﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float Speed = 8f;

	// Update is called once per frame
	void Update () 
	{
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3 (0, Speed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;

		transform.position = pos;
	}
}