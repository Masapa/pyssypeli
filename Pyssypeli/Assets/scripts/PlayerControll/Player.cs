using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	void Awake(){
		StartLife ();

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy" || other.tag == "Bullet") {
			Debug.Log ("KUOLIT AHAHAH VITTU!");
		}
	}

	// Use this for initialization
	void Start () {

		StartWeapon ();
		LoadTommygun ();
	}
	
	// Update is called once per frame
	void Update () {
		DeathCheck ();
		AmmoCheck ();

		if (Input.GetKeyDown (KeyCode.Alpha1)){LoadFists();Debug.Log("Sullon fistit");}
		if (Input.GetKeyDown (KeyCode.Alpha2)&&GotHandgun==true){LoadHandgun();Debug.Log("Sullon pisla");}
		if (Input.GetKeyDown (KeyCode.Alpha3)&&GotTommygun==true){LoadTommygun();Debug.Log("Sullon SKP");}



		if (Input.GetButtonDown ("Reload")) {
			float tick = Gun.ReloadTime/98;
			CancelInvoke("ReloadAnimation");
			ammoSlider.value = 0;
			if(ammoSlider.value < 101)
			{
				InvokeRepeating("ReloadAnimation",0,tick);


				//if(ammoSlider.value >= 100)
				
				
			}

		
		
		}

	}




}

