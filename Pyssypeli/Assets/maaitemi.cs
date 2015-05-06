using UnityEngine;
using System.Collections;

public class maaitemi : MonoBehaviour {

	public bool hiilaus = true;
	public int health = 50;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			other.SendMessage("giveHealth",health,SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
