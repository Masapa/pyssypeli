using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform patrolDest;
	private Transform myTransform;
	public GameObject Bullet;
	public int moveSpeed;
	public int rotationSpeed;
	private Player health;
	public LayerMask WhatToHit;

	Transform Target;
	Transform _sightEnd;
	public bool spotted = false;
	private bool seuraa = false;
	private bool näkee = false;
	private bool jahtaa = false;
	private bool ampuu = false;
	private bool katsoo = false;
	private bool palaudu = false;
	Rigidbody2D tmp;

	int MaxMag = 12;
	int Mag = 12;

	float Frate = 2;
	float RTime = 2;
	float Reloader = 0;
	float TimeToFire = 0;
	bool seuraas = false;
	detectionienemy seuraaas;
	GameObject aseenkärki;
	Transform aseenkarkii;
	void Awake()
	{
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		seuraaas = GetComponentInChildren<detectionienemy>();
		myTransform = transform;
		Transform[] ts = transform.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) {
			if(t.gameObject.name == "Piippu"){aseenkarkii = t;}
		
		}

		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		// _sightEnd = sightEnd;
		Target = go.transform;
		tmp = GetComponent<Rigidbody2D> ();
		// ymp = Target.GetComponents<CircleCollider2D>;
	}
	/*
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
	}*/
	// Update is called once per frame
	void FixedUpdate () {

		Reloader -= Time.smoothDeltaTime;
		
		if (Reloader < 0 && Reloader >= -.2) {								//tarkistaa millon ase on valmis
			Mag = MaxMag;
		}
		
		if (Mag == 0 && Reloader < -.2) {		//laittaa aseen lataamaan kun painaa "R"
			Reloader = RTime;
		}

	}


	void Update()
	{
		seuraas = seuraaas.tila;
		seuraa = seuraas;
		Raycasting ();
		
	}
	
	void Raycasting()
	{
		// Debug.DrawLine (sightStart.position, (sightEnd.position-sightStart.position)*50, Color.green);
		Debug.DrawLine (myTransform.position, Target.position, Color.green);
		
		// RaycastHit2D spotted = Physics2D.Raycast (sightStart.position, sightEnd.position-sightStart.position, 15, WhatToHit);
		RaycastHit2D spotted = Physics2D.Raycast (myTransform.position, (Target.position - myTransform.position), 12, WhatToHit);
		if (spotted.collider != null && spotted.collider.name == "Player") {
			Debug.DrawLine (myTransform.position, spotted.point, Color.red);
			näkee = true;
		} 
		
		
		if (näkee == true) {
			seuraa = true;
		}

		if (seuraa == true && näkee == true) {
			jahtaa = true;
			katsoo = true;
			
			//Debug.Log ("JAHTAA");
		}

		if (katsoo == true) {
			Turret ();
		}
		
		if (spotted.collider.name != "Player") {
			näkee = false;
		}
		
		if (seuraa == false || näkee == false) {
			jahtaa = false;
			//Debug.Log ("EI JAHTAA");
		}

		if(ampuu == true)
		{
			Shooting();
		}

		if (jahtaa == true) {
			Chase ();
			ampuu = true;
		}
		
		if (jahtaa == false) {
			Patrolling ();
		}
	}
	
	void Patrolling()
	{
		palaudu = true;
	}
	
	void Chase()
	{
		Vector3 dir = Target.position - myTransform.position; 
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg; 
		
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); 
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, q, Time.deltaTime * rotationSpeed);
		
		
		if (Vector3.Distance (Target.position, myTransform.position) > (10 + 1f)) {
			tmp.velocity = tmp.transform.rotation * Vector2.right * moveSpeed;
		} 
		
		else if (Vector3.Distance (Target.position, myTransform.position) < (10 - 1f)) {
			tmp.velocity = tmp.transform.rotation * -Vector2.right * moveSpeed * 0.75f;
		}
		
		else {
			tmp.velocity = Vector2.zero;
		}
		
	}
	
	void Turret()
	{
			Vector3 dir = Target.position - myTransform.position; 
			float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg; 
			
			Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); 
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation, q, Time.deltaTime * rotationSpeed);
			
			Shooting ();
	
	}
	
	void Shooting()
	{
		Debug.Log("AMPUUUU phase1");
	if (Time.time > TimeToFire && Mag > 0 && Reloader < -.2) {
		Debug.Log("AMPUUUU phase2");
		TimeToFire = Time.time + 1 / Frate;
		Shoot();
		Mag--;
		}
	}

	void Shoot()
	{

		Instantiate (Bullet, aseenkarkii.position, (myTransform.rotation * Quaternion.Euler(0,0,-90)));
	}
}