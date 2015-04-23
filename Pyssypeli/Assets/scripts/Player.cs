using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		bullshit ();
		ballshit ();
	
	}

	void OnTriggerEnter2D(){
		Debug.Log ("KUOLIT AHAHAH VITTU!");
	}

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){
		TakeDamage (10);
			Shoot (1);
		}

		if(Input.GetButtonDown("Reload")){
			Reload2();
		}
	
	}
}
