using UnityEngine;
using System.Collections;

public class Bulletti : MonoBehaviour {

	//public float Velocity;
	//public float Damage;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	Rigidbody.velocity = Bullet.transform.rotation * Vector2.up*5;
	
	//Rigidbody2D.velocity = .transform
	}
}
