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
	
	public Weapon Gun;
	public BulletScript Bullet;

	void StartWeapon(){
		Gun = (Weapon)this.GetComponentInChildren<Weapon> ();
		Bullet = (BulletScript)this.GetComponent<BulletScript> ();
	}
	
	void LoadFists(){
		//int
		Gun.MaxMag = 1;				// lippaan koko
		Gun.Damage = 1;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "0";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "0";		// lataus nopeus
		Gun.Speed = "1";
	}

	void LoadHandgun(){
		//int
		Gun.MaxMag = 20;			// lippaan koko
		Gun.Damage = 3;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "2";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "1";		// lataus nopeus
		Gun.Speed = "2";
	}

	void LoadTommygun(){
		//int
		Gun.MaxMag = 40;			// lippaan koko
		Gun.Damage = 1;				// aseen vahinko
		Gun.Amount = 1;				// panoksia/laukaus
		
		//String
		Gun.Delay = "0";			// kuinka kauan nappia pitää painaa että ampuminen alkaa
		Gun.FireRate = "6";			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.ReloadTime = "2";		// lataus nopeus
		Gun.Speed = "3";
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