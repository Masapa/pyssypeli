using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float maxspeed = 100f;
	public float speed;
	public Rigidbody2D rb;
	bool ylos = false;
	bool alas = false;
	bool vasen = false;
	bool oikea = false;

	// private float maxSpeed = 5f;
	// Use this for initialization
	void Start () 
	{
		//rb = GetComponent<Rigidbody2D> ();
	}


	void Update(){

		if (Input.GetKeyDown ("w")) {
			ylos = true;
		}
		if (Input.GetKeyUp ("w"))
			ylos = false;

		if (Input.GetKeyDown ("s")) {
			alas = true;
		}
		if (Input.GetKeyUp ("s"))
			alas = false;

		if (Input.GetKeyDown ("a")) {
			vasen = true;
		}
		if (Input.GetKeyUp ("a"))
			vasen = false;

		if (Input.GetKeyDown ("d")) {
			oikea = true;
		}
		if (Input.GetKeyUp ("d")) {
			oikea = false;
		}
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (ylos) {
			if(rb.velocity.y <= maxspeed){
			rb.AddForce(transform.up * speed);
				rb.drag = 1f;}


		}


		

		if (alas) {
			if(-rb.velocity.y <= maxspeed){
			rb.AddForce (-transform.up * speed);
				rb.drag = 1f;}

		}


		

		if (oikea) {
			if(rb.velocity.x <= maxspeed){
			rb.AddForce (transform.right * speed);
					rb.drag = 1f;}
			
		}



		if (vasen) {
			if(-rb.velocity.x <= maxspeed){
			rb.AddForce (-transform.right * speed);
			rb.drag = 1f;
					}

			}



		if (!(ylos || alas || oikea || vasen)) {rb.drag = 5f;
		}
	}
}
	
