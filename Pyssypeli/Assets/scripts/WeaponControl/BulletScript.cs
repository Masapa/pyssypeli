﻿using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float Speed = 8f;		//panoksen lentonopeus
	public float Damage = 2f;		//panoksen vahinko
	private float Siivous = 2;		//aika jolloin panos katoaa (varmuuden vuoksi)
	Rigidbody2D rb;

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player" || other.tag == "HardObject" || other.tag == "Seina" || other.tag == "Enemy"){
			Destroy (gameObject);
		}
	}

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate (){
		Siivous -= Time.deltaTime;
		if (Siivous < 0) {
			Destroy (gameObject);
		}
		rb.velocity = rb.transform.rotation * Vector2.up * Speed;
	}
}