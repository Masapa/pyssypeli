using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {

	public bool Handgun = false;
	public bool Flamethrower = false;
	public bool Rifle = false;
	public bool Boomstick = false;
	public bool Gatlinggun = false;

	void LoadFists(){
	}

	void LoadHandgun(){
		Gun.fireRate = 0;			// 0-puoliautomaatti, >1 sarja ja sen tiheys
		Gun.MaxMag = 20;			// lippaan koko
		Gun.Mag = 0;				// panoksia lippaassa
		Gun.RTime = 2f;				// lataus nopeus
		bullet.Speed = 8f;			// panoksen lentonopeus
		bullet.Damage = 2f;			// panoksen vahinko
		bullet.Amount = 0f;			// panoksia/laukaus
		//bullet.Siivous = 2;			// aika jolloin panos katoaa (varmuuden vuoksi)
	}

	void LoadFlamethrower(){
	}

	void LoadRifle(){
	}

	void LoadBoomstick(){
	}

	void LoadTommygun(){
	}

	void LoadGatlinggun(){
	}

}