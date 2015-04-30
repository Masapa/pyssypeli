using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform Target;
	public Transform sightStart, sightEnd;
	public Transform patrolDest;
	private Transform myTransform;
	Transform _sightEnd;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;
	bool seuraa = false;
	bool näkee = false;
	bool jahtaa = false;
	bool ampuu = false;
	Rigidbody2D tmp;

	private Player health;
	public bool spotted = false;
	public LayerMask WhatToHit;

	void Awake()
	{
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		_sightEnd = sightEnd;
		Target = go.transform;
		tmp = GetComponent<Rigidbody2D> ();
		maxdistance = 10;

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Debug.Log("Lähellä on jokuuuu");
			seuraa = true;
		
		}
	
	
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			seuraa = false;
			Debug.Log("Se meni pois");
		}
	}
	// Update is called once per frame
	void FixedUpdate () {

		/*if (seuraa && spotted == true) {
			Chase ();
		}*/

		if ((Vector3.Distance (Target.position, myTransform.position) == maxdistance)) {
			Shooting ();
		}

	}

	void Update()
	{

		Raycasting ();

	}

	void Raycasting()
	{
		// Debug.DrawLine (sightStart.position, (sightEnd.position-sightStart.position)*50, Color.green);
		Debug.DrawLine (myTransform.position, Target.position, Color.green);

		// RaycastHit2D spotted = Physics2D.Raycast (sightStart.position, sightEnd.position-sightStart.position, 15, WhatToHit);
		RaycastHit2D spotted = Physics2D.Raycast (myTransform.position, (Target.position - myTransform.position), 15, WhatToHit);
		if (spotted.collider != null && spotted.collider.name == "Player") {
			Debug.DrawLine (myTransform.position, spotted.point, Color.red);
			näkee = true;
		} 


		if (näkee == true) {
			seuraa = true;
		}
		if (seuraa == true && näkee == true) {
			jahtaa = true;
			Debug.Log ("JAHTAA");
		}

		if (spotted.collider.name != "Player") {
			näkee = false;
		}

		if (seuraa == false || näkee == false) {
			jahtaa = false;
			Debug.Log ("EI JAHTAA");
		}
		if (jahtaa == true) {
			Chase ();
			Shooting();
		}

		if (jahtaa == false) {
			Patrolling ();
		}
	}

	void Patrolling()
	{
		tmp.velocity = tmp.transform.rotation * Vector2.right * 0;
	}

	void Chase()
	{
		Vector3 dir = Target.position - myTransform.position; 
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg; 
		
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); 
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, q, Time.deltaTime * rotationSpeed);

		
		if (Vector3.Distance (Target.position, myTransform.position) > (maxdistance + 1f)) {
			tmp.velocity = tmp.transform.rotation * Vector2.right * moveSpeed;
		} 

		else if (Vector3.Distance (Target.position, myTransform.position) < (maxdistance - 1f)) {
			tmp.velocity = tmp.transform.rotation * -Vector2.right * moveSpeed * 0.75f;
		}

		else {
			tmp.velocity = Vector2.zero;
		}

	}

	void Shooting()
	{
		ampuu = true;


	}
}