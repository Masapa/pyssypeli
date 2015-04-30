using UnityEngine;
using System.Collections;

public class detectionienemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public bool tila = false;
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Debug.Log("Lähellä on jokuuuu");
			tila = true;
			
		}
		
		
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			tila = false;
			Debug.Log("Se meni pois");
		}
	}
}
