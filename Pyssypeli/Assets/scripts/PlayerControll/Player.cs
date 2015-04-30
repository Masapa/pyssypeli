using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		StartLife ();
		StartWeapon ();
		GotTommygun = true;
	}

	// Use this for initialization
	void Start () {
		LoadFists ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Enemy" || other.tag == "Bullet") {
			InvokeRepeating("TakeDamage", 0, 0);
			Debug.Log ("KUOLIT AHAHAH VITTU!");
		}
		if (other.tag == "Item") {
			LoadHandgun ();
			Gun.Mag = Gun.MaxMag;
		}
	}

	//void OnTriggerStay2D(Collider2D other){

	
	// Update is called once per frame
	void Update () {
		DeathCheck ();
		AmmoCheck ();

		if (Input.GetKeyDown (KeyCode.Alpha1)){LoadFists();Debug.Log("Sullon fistit");}
		if (Input.GetKeyDown (KeyCode.Alpha2)&&GotHandgun==true){LoadHandgun();Debug.Log("Sullon pisla");}
		if (Input.GetKeyDown (KeyCode.Alpha3)&&GotTommygun==true){LoadTommygun();Debug.Log("Sullon SKP");}
		/*if (Input.GetKeyDown (KeyCode.Alpha4)&&GotGatlinggun==true){LoadGatlinggun();}
		if (Input.GetKeyDown (KeyCode.Alpha5)&&GotRifle==true){LoadRifle();}
		if (Input.GetKeyDown (KeyCode.Alpha6)&&GotBoomstick==true){LoadBoomstick();}
		if (Input.GetKeyDown (KeyCode.Alpha7)&&GotFlamethrower==true){LoadFlamethrower();}*/
	}
}
