using UnityEngine;
using System.Collections;

public class PickupHandgun : MonoBehaviour {

	Player inventory;
	
	void Start(){
		inventory = (Player)GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<Player> ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player") {
			inventory.Handgun = true;
			Destroy(gameObject);
		}
	}
}