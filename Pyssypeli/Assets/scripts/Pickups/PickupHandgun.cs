using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PickupHandgun : MonoBehaviour {

	Player inventory;
	
	void Start(){
		inventory = (Player)GameObject.FindGameObjectWithTag ("Player").GetComponentInChildren<Player> ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player") {
			inventory.GotHandgun = true;
			Destroy(gameObject);
		}
	}
}