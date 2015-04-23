using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {


	public int StartingAmmo = 12;
	public int CurrentAmmo;

	public Text	currentAmmo;				
	public Text startingAmmo;


	void ballshit(){
		CurrentAmmo = StartingAmmo;
	}

	public void Shoot (int amount)
	{

		damaged = true;
		
		if (CurrentAmmo > 0) {
			CurrentAmmo -= amount;
		

			currentAmmo.text = CurrentAmmo.ToString ();
		}

		
	}
	public void Reload2(){
		CurrentAmmo = StartingAmmo;
		currentAmmo.text = CurrentAmmo.ToString ();


	}

}
