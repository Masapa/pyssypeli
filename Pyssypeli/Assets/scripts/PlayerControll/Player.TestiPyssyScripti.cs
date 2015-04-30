using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	public Text	currentAmmo;				
	public Text maxAmmo;

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


