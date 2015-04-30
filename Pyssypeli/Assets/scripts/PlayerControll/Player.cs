using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		StartLife ();

		StartWeapon1 ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy" || other.tag == "Bullet") {
			TakeDamage(11);
			Debug.Log ("KUOLIT AHAHAH VITTU!");
		}
	}

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		DeathCheck ();
		AmmoCheck ();

		if (Input.GetButton ("Reload")) {
			float tick = Gun.RTime/100;

			if()
			{
				
			}

		
		
		}

	}




}
