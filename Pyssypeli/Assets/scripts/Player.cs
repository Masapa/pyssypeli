using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		bullshit ();
	
	
	}
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){
		TakeDamage (10);
		}
	
	}
}
