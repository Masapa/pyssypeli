using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	public Transform Target;
	public int moveSpeed;
	public int rotationSpeed;
	public int maxdistance;
	bool seuraa = false;
	Rigidbody2D tmp;
	private Transform myTransform;
	private Player health;
	public enum SpriteRotation
	{
		Up = -90,
		Right = 0,
		Down = 90,
		Left = 180
		
	}
	public SpriteRotation initialRotation;

	private Vector2 _direction;
	private Vector2 _mousePosition;
	private Transform _transform;
	private float _angle;
	

	void Awake()
	{
		myTransform = transform;
	}
	
	// Use this for initialization
	void Start () {
		_transform = transform;
		GameObject go = GameObject.FindGameObjectWithTag ("Player");

		Target = go.transform;
		tmp = GetComponent<Rigidbody2D> ();
		maxdistance = 10;

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
		
			seuraa = true;
		
		}
	
	
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player") {
			seuraa = false;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (seuraa) {
			Chase ();
		}

		if ((Vector3.Distance (Target.position, myTransform.position) == maxdistance)) {
			Shooting ();
		}
	}

	void Chase()
	{
		Vector3 dir = Target.position - myTransform.position; 
		float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg; 
		
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward); 
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, q, Time.deltaTime * rotationSpeed);
		
		if (Vector3.Distance (Target.position, myTransform.position) > (maxdistance + 1f)) {
			tmp.velocity = tmp.transform.rotation * Vector2.right * moveSpeed;
		} 

		else if (Vector3.Distance (Target.position, myTransform.position) < (maxdistance - 1f)) {
			tmp.velocity = tmp.transform.rotation * -Vector2.right * moveSpeed * 0.75f;
		}

		else {
			tmp.velocity = Vector2.zero;
		}

	}

	void Shooting()
	{

	}
}