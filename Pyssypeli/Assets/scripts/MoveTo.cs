using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform Target;
	public Transform sightStart, sightEnd;
	Transform _sightEnd;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;
	bool seuraa = false;
	Rigidbody2D tmp;
	private Transform myTransform;
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
		
			seuraa = true;
		
		}
	
	
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			seuraa = false;
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
		Debug.DrawLine(myTransform.position, Target.position, Color.green);
		//Debug.DrawLine (new Vector3(., sightEnd.position, Color.green);
		RaycastHit2D spotted = Physics2D.Raycast (myTransform.position, Target.position, 11, WhatToHit);
		if (seuraa == true && spotted.collider != null) {
			Debug.DrawLine(myTransform.position, Target.position, Color.red);
			Chase ();
		}
	
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

	}
}