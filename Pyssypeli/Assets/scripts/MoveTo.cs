using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform Target;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;

	Rigidbody2D tmp;
	private Transform myTransform;
	

	void Awake()
	{
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");

		Target = go.transform;
		tmp = GetComponent<Rigidbody2D> ();
		maxdistance = 10;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.DrawLine(Target.position, myTransform.position, Color.red);

		Vector3 dir = Target.position - myTransform.position; 
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg; 

		Quaternion q = Quaternion.AngleAxis(angle-90, Vector3.forward); 
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, q, Time.deltaTime * rotationSpeed);

		if (Vector3.Distance (Target.position, myTransform.position) > (maxdistance + 1f)) {
			tmp.velocity = tmp.transform.rotation * Vector2.up * moveSpeed;


		} else if (Vector3.Distance (Target.position, myTransform.position) < (maxdistance - 1f)) {
			tmp.velocity = tmp.transform.rotation * -Vector2.up * moveSpeed * 0.75f;

		}
		else {
			tmp.velocity = Vector2.zero;
		}
	}
}