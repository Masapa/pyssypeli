using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	public Text	currentAmmo;				
	public Text maxAmmo;

<<<<<<< HEAD
=======
	void StartWeapon1(){
		Gun = (Weapon)this.GetComponentInChildren<Weapon> ();;
	}

	void ballshit(){
		MaxAmmo = MaxAmmo;
		CurrentAmmo = MaxAmmo;
	}

>>>>>>> f06a1b57306e5c163f00a47aeddb4948dd878350
	void AmmoCheck ()
	{
		maxAmmo.text = Gun.MaxMag.ToString ();
		currentAmmo.text = Gun.Mag.ToString ();
		}

		
	}
	/*void Reload2(){
		CurrentAmmo = MaxAmmo;
		currentAmmo.text = CurrentAmmo.ToString ();


	}'*/


