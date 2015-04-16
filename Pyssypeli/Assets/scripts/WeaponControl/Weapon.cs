using UnityEngine;
using System.Collections;

public class deaponControl : MonoBehaviour {

	public GameObject Bullet;
	public float fireRate = 0;
	public float Magazine = 20;
	public float RTime = 2f;
	public float Mag = 0;
	float Reloader = -1;
	float timeToFire = 0;
	Transform firePoint;

	void SetGuns(){
		Mag = Magazine;
	}

	void FindGun(){

	}

	void ShootLoad(){

		Reloader -= Time.deltaTime;
		
		if (Reloader < -6) {							//ettei mee liian pitkälle
			Reloader = -1;
		}
		
		if (Reloader <= 0 && Reloader >= -.5) {			//tarkistaa millon ase on valmis	
			Mag = Magazine;
		}
		
		if (Input.GetButton ("Reload") && Reloader < -.5) {	//laittaa aseen lataamaan kun painaa "R"
			Reloader = RTime;
		}
		
		if (fireRate == 0 && Mag > 0 && Reloader < -.5) {
			if (Input.GetButtonDown ("Fire1")) {

				Vector3 pos = transform.position;
				Instantiate (Bullet, transform.position, transform.rotation);

				Mag--;
			}
		} else {
			
			if (Input.GetButton ("Fire1") && Time.time > timeToFire && Mag > 0 && Reloader < -.5) {
				timeToFire = Time.time + 1 / fireRate;
				Shoot ();
				Mag--;
			}
		}
	}


	void Shoot(){
	}
		

	
}
