using UnityEngine;
using System.Collections;

public class CollisionD : MonoBehaviour {
	

	public int health = 10;
	GameObject fak;
	Weapon Gun;

	void OnTriggerStay2D(){
		InvokeRepeating ("TakeDamage", 0, 0);
	}

	void TakeDamage(){
		health -= Gun.Damage;
	}
	
	void Death(){
		if (health <= 0)
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		fak = GameObject.Find ("FirePoint");
		Gun = fak.GetComponent<Weapon> ();
	}
	
	// Update is called once per frame
	void Update () {
			Death ();
	}
}
