using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {
	
	Weapon Gun;
	
	public Slider ammoSlider;


	public Text	currentAmmo;				
	public Text maxAmmo;

	void StartWeapon1(){
		Gun = (Weapon)this.GetComponentInChildren<Weapon> ();
	}


	void AmmoCheck ()
	{
		maxAmmo.text = Gun.MaxMag.ToString ();
		currentAmmo.text = Gun.Mag.ToString ();
	}


	void ReloadAnimation(){
		ammoSlider.value += 1;
	}

}