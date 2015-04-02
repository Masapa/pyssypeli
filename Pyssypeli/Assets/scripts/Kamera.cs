using UnityEngine;
using System.Collections;

public class Kamera : MonoBehaviour {

	public Transform target;
	public Transform player;
	//public float dampTime = 0.1f;
	public float smoothTime;
	public float smoothTimex;
	private Transform thisTransform;
	
	float tmp;
	
	// Use this for initialization
	void Start () {
		tmp = 0;
		if (smoothTime == 0) {
			smoothTime = 0.6f;
		}
		
		if (smoothTimex == 0) {
			smoothTimex = smoothTime;
		}
		
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -15);
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		float x = Mathf.Clamp (transform.position.x, player.transform.position.x, player.transform.position.x);
		float y = Mathf.Clamp (transform.position.y, player.transform.position.y, player.transform.position.y);
		transform.position = new Vector3 (x + tmp, y, transform.position.z);
	}
}
