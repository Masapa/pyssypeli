using UnityEngine;
using System.Collections;

public class CollisionD : MonoBehaviour {
	

	public float hp = 10;
	public BulletScript bullet;

	void OnTriggerEnter2D(){
		hp -= bullet.Damage;
	}
	
	void Death(){
		Destroy (gameObject);
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (hp <= 0) {
			Death ();
		}
	}
}
