using UnityEngine;
using System.Collections;

public class seina : MonoBehaviour {
	public bool kulma = false; // onko kulmassa vai suorassa;
	public bool oikea = false; // kulma oikeaan vai vasempaan;
	public bool ala = false;
	public float x;
	public float y;
	Rigidbody2D rb2;
	Vector3 testiii;
	// Use this for initialization
	void Start () {

		rb2 = GetComponent<Rigidbody2D> ();
	/*	if (ala && kulma && !oikea)
			transform.Rotate (0, 0, -30);
		if (ala&&oikea && kulma )
			transform.Rotate (0, 0, 30+180);
		if (!ala && oikea && kulma)
			transform.Rotate (0, 0, 180-30);
		if (!ala && !oikea && kulma)
			transform.Rotate (0, 0, 30);
		if (!kulma) {
			transform.Rotate (0, 0, 90);
		}*/
		//tila (2, 4);

		//transform.localScale = new Vector2 (2, 1);
	
		float testiii = transform.gameObject.GetComponent<SpriteRenderer> ().bounds.extents.x;
		Debug.Log (testiii);
	}
	public void tila(float x,float y){
		this.transform.position = new Vector3 (x, y,0);


	}
	
	// Update is called once per frame
	void Update () {
		//rb2.isKinematic = true;
		rb2.fixedAngle = true;
		x = transform.position.x;
		y = transform.position.y;
	}
}
