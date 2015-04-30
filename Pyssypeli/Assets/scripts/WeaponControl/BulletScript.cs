using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour {

	Rigidbody2D rb;
	float Speed = 10f;
	float Siivous = 3f;

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player" || other.tag == "Enemy"){
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "HardObject" || other.collider.tag == "Seina" || other.collider.tag == "Enemy") {
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