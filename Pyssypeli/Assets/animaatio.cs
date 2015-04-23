using UnityEngine;
using System.Collections;

public class animaatio : MonoBehaviour {

	Animator asd;
	// Use this for initialization
	void Start () {
		asd = GetComponent<Animator>();
		asd.SetBool ("Firing", true);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.C)) {
			asd.SetBool("Firing",false);
		}
	
	}
}
