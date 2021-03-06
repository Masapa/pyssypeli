﻿using UnityEngine;
using System.Collections;
public class RotateToMouse : MonoBehaviour {

	public enum SpriteRotation
	{
	  	Up = -90,
		Right = 0,
		Down = 90,
		Left = 180

	}

	public Camera currentCamera;
	public SpriteRotation initialRotation;

	private Vector2 _direction;
	private Vector2 _mousePosition;
	private Transform _transform;

	private float _angle;

	


	void Start () 
	{
		_transform = transform;

		if (!currentCamera)
			currentCamera = Camera.main;

	}
	

	void Update () 
	{
		_mousePosition = currentCamera.ScreenToWorldPoint (Input.mousePosition);
		_direction = (_mousePosition - (Vector2)_transform.position).normalized;

		_angle = Mathf.Atan2 (_direction.y, _direction.x) * Mathf.Rad2Deg + (int)initialRotation;
		_transform.rotation = Quaternion.AngleAxis (_angle, Vector3.forward);

	}
}