using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float Speed = 8f;
	public float Damage = 2f;
	private float Varma = 2;
	Rigidbody2D rb;

	void OnTriggerEnter2D(){
		Destroy (gameObject);
	}

	void Start(){
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () 
	{
		Varma -= Time.deltaTime;
		if (Varma < 0) {
			Destroy (gameObject);
		}
		rb.velocity = rb.transform.rotation * Vector2.up * Speed;
	}
}