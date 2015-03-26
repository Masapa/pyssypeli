using UnityEngine;
using System.Collections;

public class guntest : MonoBehaviour {



	public float fireRate = 0;
	public float damage = 10;
	public LayerMask notToHit;

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

	void Shoot(){
		Debug.Log ("tää toimii pikkukoira");

	}

}
