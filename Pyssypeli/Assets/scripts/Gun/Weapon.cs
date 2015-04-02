using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	
	
	
	public float fireRate = 0;
	public float Damage = 10;
	//public LayerMask whatToHit;
	public GameObject MagicBullet;
	
	float timeToFire = 0;
	Transform firePoint;
	
	
	void Awake(){
		firePoint = transform.FindChild ("FirePoint");
		if (firePoint == null) {
			Debug.LogError("no firepointtia whattaa fuuuu");
		}
		
	}
	
	void Update(){
		if (fireRate == 0) {
			if (Input.GetButtonDown ("Fire1")) {
				Shoot ();
			}
		} else {
			if (Input.GetButton ("Fire1") && Time.time > timeToFire){
				timeToFire = Time.time + 1/fireRate;
				Shoot();
			}
		}
	}
	//4:25
	void Shoot()
	{
		Instantiate (MagicBullet, transform.position, Quaternion.identity);

	}
		

	
}
