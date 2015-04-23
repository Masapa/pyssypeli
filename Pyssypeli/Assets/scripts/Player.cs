using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		bullshit ();
		ballshit ();
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy" || other.tag == "Bullet") {
			Debug.Log ("KUOLIT AHAHAH VITTU!");
			PlayerDied();
		}
	}

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
