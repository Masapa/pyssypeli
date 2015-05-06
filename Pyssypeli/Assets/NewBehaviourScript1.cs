using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	public float rotationSpeed;
	public float movementSpeed;
	public float rotationTime;
	Animator anim;


	// Use this for initialization
	void Start () {
	
		Invoke("ChangeRotation",rotationTime);
		anim = GetComponent<Animator>();

	}

	void ChangeRotation() {
		if(Random.value > 0.5f)  {
			rotationSpeed = -rotationSpeed;
		}
		Invoke("ChangeRotation",rotationTime);
	}




	// Update is called once per frame
	void Update () {

		transform.Rotate (new Vector3 (0, 0, rotationSpeed * Time.deltaTime));
		transform.position += transform.up*movementSpeed*Time.deltaTime;
		anim.SetFloat ("speed", Mathf.Abs(movementSpeed)); 
	
	}
}
