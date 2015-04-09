using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float Speed = 8f;
	Rigidbody2D rb;
	void Start(){
		rb = GetComponent<Rigidbody2D> ();


	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector2 pos = transform.position;

		//Vector2 velocity = new Vector3 (0, Speed * Time.deltaTime);
		rb.velocity = rb.transform.rotation * Vector2.up * Speed;


		//pos += transform.rotation * velocity;

		//transform.position = pos;
	}
}