using UnityEngine;
using System.Collections;

public class pakotusovi : MonoBehaviour {
	Rigidbody2D rb;
	public bool vittuovi = false;
	Quaternion alkutila;
	// Use this for initialization
	void Start () {
		 rb = GetComponent<Rigidbody2D> ();
		alkutila = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (!vittuovi) {
			transform.rotation = rb.transform.rotation;
			//rb.isKinematic = false;
			rb.fixedAngle = false;
		} else{
			//rb.isKinematic = true;
			rb.fixedAngle = true;
			transform.rotation = alkutila;
		rb.transform.rotation = alkutila;
	}
	}

	public void lukitse(){vittuovi = true;}
}
