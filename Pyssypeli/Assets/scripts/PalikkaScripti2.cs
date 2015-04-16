using UnityEngine;
using System.Collections;

public class PalikkaScripti2 : MonoBehaviour {

	public float liike;
	float alku;
	public bool oikea = false;

	private bool dirRight = true;
	public float speed = 2.0f;

	void Start(){

		alku = transform.position.x;



	}


	// Update is called once per frame
	void Update () {


		if (dirRight)
			transform.Translate (Vector2.right * speed * Time.deltaTime);
		else
			transform.Translate (-Vector2.right * speed * Time.deltaTime);
		if (!oikea) {
			if (transform.position.x >= alku) {

					dirRight = false;
			}
		}

		if (oikea) {
			if (transform.position.x <= alku) {

					

					dirRight = true;
			}
		}

		if (!oikea) {
			if (transform.position.x <= alku - liike) {
				dirRight = true;
			}
		}
		if (oikea) {
			if (transform.position.x >= alku + liike) {
				dirRight = false;
			}

		}
	
	}
}
