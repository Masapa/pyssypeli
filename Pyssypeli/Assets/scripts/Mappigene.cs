using UnityEngine;
using System.Collections;

public class Mappigene : MonoBehaviour {
	public int x = 2;
	public int y = 3;
	Rigidbody2D testi = new Rigidbody2D ();
	
	SpriteRenderer testi1 = new SpriteRenderer ();

	public Sprite testii;
	// Use this for initialization
	void Start () {
		testi1.sprite = testii;
		testi1.enabled = true;

		testi1.transform.localPosition = new Vector2 (0, 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
