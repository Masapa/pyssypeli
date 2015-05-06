using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform patrolDest;
	private Transform myTransform;
	public GameObject Bullet;
	public int moveSpeed;
	public int rotationSpeed;
	public LayerMask WhatToHit;

	Rigidbody2D ammus;
	Weapon ase;
	Player asd;
	GameObject pelaaja;
	Transform Target;
	Transform _sightEnd;
	private bool spotted = false;
	private bool seuraa = false;
	private bool näkee = false;
	private bool jahtaa = false;
	private bool ampuu = false;
	private bool palaudu = false;
	Rigidbody2D tmp;
	public int Health = 100;
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

	void Start () {
	
		pelaaja = GameObject.Find ("Pelaaja");
		asd = GetComponent<Player> ();
		ase = GetComponent<Weapon> ();
		Bullet = Resources.Load ("Bullet") as GameObject;
		seuraaas = GetComponentInChildren<detectionienemy>();
		myTransform = transform;
		Transform[] ts = transform.GetComponentsInChildren<Transform>();
		foreach (Transform t in ts) {
			if(t.gameObject.name == "Piippu"){aseenkarkii = t;}
		
		}

		GameObject go = GameObject.FindGameObjectWithTag ("Player");

		Target = go.transform;
		tmp = GetComponent<Rigidbody2D> ();

	}

	public void TakeDamage (int d)
	{
		// Set the damaged flag so the screen will flash.

		Debug.Log ("asd1");
		// Reduce the current health by the damage amount.
		Health -= d;
		
		// Set the health bar's value to the current health.
	
		
		//damaged = false;
	}

	// Update is called once per frame
	void FixedUpdate () {

		Reloader -= Time.smoothDeltaTime;
		
		if (Reloader < 0 && Reloader >= -.2) {		
			Mag = MaxMag;
		}
		
		if (Mag == 0 && Reloader < -.2) {	
			Reloader = RTime;
		}


	}

	void tarkistaKuolema(){

		if (Health <= 0) {
			Destroy(gameObject);
		
		}

	}


	void Update()
	{
		seuraas = seuraaas.tila;
		seuraa = seuraas;
		Raycasting ();

		tarkistaKuolema ();
		
	}
	
	void Raycasting()
	{
		Debug.DrawLine (myTransform.position, Target.position, Color.green); 
		RaycastHit2D spotted = Physics2D.Raycast (myTransform.position, (Target.position - myTransform.position), 12, WhatToHit);
		if (spotted.collider != null && spotted.collider.name == "Player") {
			näkee = true;
		} 
		
		
		if (näkee == true) {
			seuraa = true;
		}

		if (seuraa == true && näkee == true) {
			jahtaa = true;
		}

		if (spotted) {
			if (spotted.collider.name != "Player") {
				näkee = false;
			}
		}
		
		if (seuraa == false || näkee == false) {
			jahtaa = false;
			ampuu = false;
		}

		if(ampuu == true)
		{
			Shooting();
		}


		if (jahtaa == true) {
			Chase ();
			palaudu = false;
			ampuu = true;
		}
		
		if (jahtaa == false) {
			ampuu = false;
			palaudu = true;
		}

		if (palaudu == true) {
			Patrolling ();
		}
	}
	
	void Patrolling()
	{

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

	
	void Shooting()
	{
		if (Time.time > TimeToFire && Mag > 0 && Reloader < -.2) {
		TimeToFire = Time.time + 1 / Frate;
		Shoot();
		Mag--;
		}
			
	}
	
	

	void Shoot()
	{
		Instantiate (Bullet, aseenkarkii.position, (myTransform.rotation * Quaternion.Euler(0,0,-90)));

	}	


	/*void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Bullet") {
			col.SendMessage("ApplyDamage", ase.Damage, SendMessageOptions.DontRequireReceiver);
			Debug.Log("AUTS!");
		}

	}
	 hit.collider.SendMessageUpwards("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
*/
}