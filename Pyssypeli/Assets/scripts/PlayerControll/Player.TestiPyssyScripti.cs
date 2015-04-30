using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	Weapon Gun;

	public int MaxAmmo = 12;
	public int CurrentAmmo = 20;

	public Text	currentAmmo;				
	public Text maxAmmo;

	void StartWeapon1(){
		Gun = (Weapon)this.GetComponentInChildren<Weapon> ();;
	}

	void ballshit(){
		MaxAmmo = MaxAmmo;
		CurrentAmmo = MaxAmmo;
	}

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


