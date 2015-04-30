using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	public Text	currentAmmo;				
	public Text maxAmmo;

	void StartWeapon1(){
		Gun = (Weapon)this.GetComponentInChildren<Weapon> ();;
	}

	void ballshit(){
		maxAmmo = maxAmmo;
		currentAmmo = currentAmmo;
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


