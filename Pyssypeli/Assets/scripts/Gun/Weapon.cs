using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public GameObject Bullet;
	public float fireRate = 0;
	public float Magazine = 20;
	public float RTime = 2f;
	public float Mag;
	float Reload = -1;
	float timeToFire = 0;
	Transform firePoint;


	void Start(){
		Mag = Magazine;
	}
	
	void Update(){

		Reload -= Time.deltaTime;

		if (Reload < -6){Reload = -1;}

		if(Reload <= 0 && Reload >= -.5){Mag = Magazine;}

		if (Input.GetButton("Reload")){
			Reload = RTime;
		}

		if (fireRate == 0 && Mag > 0 && Reload < -.5) {
			if (Input.GetButtonDown ("Fire1")){
				Shoot ();
				Mag--;
			}
		}

		else {

			if (Input.GetButton ("Fire1") && Time.time > timeToFire && Mag > 0 && Reload < -.5){
				timeToFire = Time.time + 1/fireRate;
				Shoot();
				Mag--;
			}
		}
	}


	void Shoot(){

		Vector3 pos = transform.position;

		Instantiate (Bullet, transform.position, transform.rotation);

	}
		

	
}
