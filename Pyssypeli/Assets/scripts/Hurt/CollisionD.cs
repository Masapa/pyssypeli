using UnityEngine;
using System.Collections;

public class CollisionD : MonoBehaviour {
	

	public float health = 10;					//
	public BulletScript bullet;

	void OnTriggerEnter2D(){
		health -= bullet.Damage;
	}
	
	void Death(){
		if (health <= 0)
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			Death ();
	}
}
