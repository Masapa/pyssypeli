using UnityEngine;
using System.Collections;

public class AsteroidSpawner : MonoBehaviour {

	
	public GameObject asteroid;

	// Use this for initialization
	void Start () {
	
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	void Spawn() {

		Instantiate (asteroid, transform.position, Quaternion.identity);
		Invoke ("Spawn", 3);
	}


}
