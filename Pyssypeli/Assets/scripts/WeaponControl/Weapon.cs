using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Weapon : MonoBehaviour {
	
	public GameObject Bullet;
	public float ReloadTime;
	public float FireRate;
	public float Delay;
	public int MaxMag;
	public int MemMag;
	public int Mag;
	public int Amount;

	public int Damage;
	public float Speed;
	public float Siivous;
	public float Reloader = 0;

	float Frate;
	float RTime;

	float TimeToFire = 0;
	Transform firePoint;

	void Start(){

		Mag = MaxMag;
		MemMag = MaxMag;
	}

	void Shoot(){
	Vector3 pos = transform.position;
	for (int k = 0; k < Amount; k++) {
			GameObject panos = Instantiate (Bullet, transform.position, transform.rotation) as GameObject;
			BulletScript testi = panos.GetComponent<BulletScript>();
			testi.Damage = Damage;
			testi.Speed = Speed;
			testi.Siivous = Siivous;
			

		}
	}
	
	void FixedUpdate(){

		//PanoksenVahinko = Bullet.Damage;
		//PanoksenNopeus = Bullet.Speed;
		//PanoksenIka = Bullet.Siivous;
		RTime = ReloadTime;
		Frate = FireRate;
		Reloader -= Time.smoothDeltaTime;
		
		if (Reloader < 0 && Reloader >= -.1) {								//tarkistaa millon ase on valmis
			Mag = MaxMag;
		}
		
		if (Input.GetButton ("Reload") || Mag == 0 && Reloader < -.1) {		//laittaa aseen lataamaan kun painaa "R"
			Reloader = RTime;
		}
		
		if (Frate == 0 && Mag > 0 && Reloader < -.1) {
			if (Input.GetButtonDown ("Fire1")) {
				Shoot();
				Mag--;
			}

		} else {
			
			if (Input.GetButton ("Fire1") && Time.time > TimeToFire && Mag > 0 && Reloader < -.1) {
				TimeToFire = Time.time + 1 / Frate;
				Shoot();
				Mag--;
			}
		}
	}
}
