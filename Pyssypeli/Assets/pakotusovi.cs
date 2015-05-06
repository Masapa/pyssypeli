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
	void FixedUpdate () {

		if (!vittuovi) {
			transform.rotation = rb.transform.rotation;
			//rb.isKinematic = false;
			rb.fixedAngle = false;
		} else{
			//Debug.Log (rb.transform.rotation.x+ " " + rb.transform.rotation.y+ " " + rb.transform.rotation.z+ " " + rb.transform.rotation.w + " " + alkutila.z);
			if(rb.transform.rotation.z > (alkutila.z - 0.05f) && rb.transform.rotation.z < alkutila.z +0.05f){
			//rb.isKinematic = true;
				//Debug.Log ("Kävin näin pitkällä :o");
			rb.fixedAngle = true;
			transform.rotation = alkutila;
				rb.transform.rotation = alkutila;}
	}
	}

	public void lukitse(){vittuovi = true;}
}
