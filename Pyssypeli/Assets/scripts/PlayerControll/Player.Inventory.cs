using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	public bool GotHandgun = true;
	public bool GotTommygun = true;
	public bool GotGatlinggun = false;
	public bool GotFlamethrower = false;
	public bool GotRifle = false;
	public bool GotBoomstick = false;

	GameObject weapasd;
	Weapon weapfuck;
	GameObject Weapon;
	Weapon Gun;
 	public GameObject Blet;
	BulletScript Bullet;

	void StartWeapon(){


		Weapon = GameObject.Find("FirePoint");
		Gun = Weapon.GetComponent<Weapon> ();

	}
	
	void LoadFists(){
		//int
		Gun.MaxMag = 1;				// lippaan koko
		Gun.Amount = 1;				// panoksia/laukaus
		Gun.Damage = 1;			// osuman vahinko
		
		//float
		Gun.Delay = 0f;				// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = 0f;			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = 0f;		// lataus nopeus
		Gun.Speed = 100f;		// Panoksen nopeus
		Gun.Siivous = 0.1f;		// Millon panos haihtuu

	}

	void LoadHandgun(){
		//int
		Gun.MaxMag = 12;			// lippaan koko
		Gun.Amount = 1;				// panoksia/laukaus
		Gun.Damage = 25;			// osuman vahinko
		
		//float
		Gun.Delay = 0f;				// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = 0f;			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = 2f;		// lataus nopeus
		Gun.Speed = 12f;			// Panoksen nopeus
		Gun.Siivous = 2f;		// Millon panos haihtuu
	}

	void LoadTommygun(){
		//int
		Gun.MaxMag = 30;			// lippaan koko
		Gun.Amount = 1;				// panoksia/laukaus
		Gun.Damage = 6;			// osuman vahinko
		
		//float
		Gun.Delay = 0f;				// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = 10f;			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = 4f;		// lataus nopeus
		Gun.Speed = 12f;			// Panoksen nopeus
		Gun.Siivous = 2f;		// Millon panos haihtuu
	}
	/*
	void LoadGatlinggun(){
		//int
		Gun.MaxMag = 99;			// lippaan koko
		Gun.Damage = 1;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "2";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "12";		// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "3";		// lataus nopeus
		Gun.Speed = "1";
	}
	
	void LoadFlamethrower(){
		//int
		Gun.MaxMag = 20;			// lippaan koko
		Gun.Damage = 3;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "0";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "1";		// lataus nopeus
		Gun.Speed = "1";
	}

	void LoadRifle(){
		//int
		Gun.MaxMag = 6;				// lippaan koko
		Gun.Damage = 8;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0.5";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "0";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "3";		// lataus nopeus
		Gun.Speed = "1";
	}

	void LoadBoomstick(){
		//int
		Gun.MaxMag = 20;			// lippaan koko
		Gun.Damage = 3;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "0";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "1";		// lataus nopeus
		Gun.Speed = "1";
	}*/
}	