using UnityEngine;
using System.Collections;

public class CollisionD : MonoBehaviour {
	

	public int health = 10;
	public Weapon weapon;

	void OnTriggerStay2D(){
		InvokeRepeating ("TakeDamage", 0, 0);
	}

	void TakeDamage(){
		health -= weapon.Damage;
	}
	
	void Death(){
		if (health <= 0)
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
		weapon = (Weapon)GameObject.FindGameObjectWithTag ("Weapon").GetComponentInChildren<Weapon> ();
	}
	
	// Update is called once per frame
	void Update () {
			Death ();
	}
}
