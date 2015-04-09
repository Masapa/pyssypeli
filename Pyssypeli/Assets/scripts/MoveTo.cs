using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform Target;
	private GameObject Enemy;
	private GameObject Player;
	private float Range;
	public float Speed;
	Rigidbody2D enemi;
	
	
	// Use this for initialization
	void Start () {
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
		enemi = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Range = Vector2.Distance (Enemy.transform.position, Player.transform.position);
		if (Range <= 15f) {
			transform.Translate(Vector2.MoveTowards (Enemy.transform.position, Player.transform.position, Range) * Speed * Time.deltaTime);
		}
	}
}