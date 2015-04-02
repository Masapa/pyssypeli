using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Mappigene : MonoBehaviour {
	public int x = 7;
	public int y = 7;

	List<List<GameObject>> testi = new List<List<GameObject>>();
	public List<GameObject> seinatt = new List<GameObject> ();
	public GameObject testii2;
	public GameObject testii3;
	//float pituus = ;
	// Use this for initialization
	float salainennumero = 18.5f;
	float nextx;
	float pituus;
	float nexty;
	List<List<GameObject>> lattiat = new List<List<GameObject>>();
	void Start () {
		pituus = testii2.transform.gameObject.GetComponent<SpriteRenderer> ().bounds.extents.x;
		Debug.Log ("Vittu se on" + pituus);
		nexty = 0;
		bool eka = false;
		for (int i = 0; i<y; i++) {
			testi.Add (new List<GameObject>());
			lattiat.Add (new List<GameObject>());
			nextx = 0;
			if((i +1)%4 == 2 || (i +1)%4 == 0){if(!eka){nextx = -salainennumero/2;eka = true;}else{nextx = salainennumero/2; eka = false;}}
			for(int a = 0;a<x;a++){//asd
				int randomia = Random.Range(0,seinatt.Count);
				if(i == 0 || i == y-1 || a == 0 || a == x-1){randomia = 0;}

				testi[i].Add ((GameObject)Instantiate(seinatt[randomia]));
				bool skippi = true;
				//ylä
				if((i+1)%4==1&&a%2 == 0){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,30);nextx +=salainennumero;}
				if((i+1)%4==1&&a%2 == 1){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,180-30);nextx += salainennumero;}
				
					//keski
				if((i+1)%4==2 || (i+1)%4 == 0){if(a >(x/2)){skippi = false;testi[i][a].transform.position = new Vector2(-100f,-100f);} if(skippi){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,90);nextx += salainennumero*2;
						lattiat[i].Add ((GameObject)Instantiate (testii3));
						lattiat[i][testi[i].Count-1].transform.position = new Vector2(nextx-salainennumero,nexty);
					}}

				//ala
				if((i+1)%4==3&&a%2 == 0){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,180-30);nextx +=salainennumero;}
				if((i+1)%4==3&&a%2 == 1){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,30);nextx += salainennumero;}

				/*
					if((i+1)%2==0){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,90);nextx += 61.51644f*2;}

					if((i+1)%2==1&&a%2 == 0){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,180-30);nextx +=61.51644f;}
					if((i+1)%2==1&&a%2 == 1){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,30);nextx += 61.51644f;}
				}*/
				
			}


			nexty -= 16.03f;
		}

	/*	testi.Add ((GameObject)Instantiate(testii2));
		//seina other = testi [0].GetComponent ("seina");
		//other.tila (-2, 0);
		testi [0].transform.position = new Vector2 (-2, 0);
		testi [1].transform.position = new Vector2 (4, 3);
		testi[0].transform.Rotate (new Vector3(0,0,30));

		seina seeeina = (seina)testi [0].GetComponent ("Seina");

		//seeeina.transform.position = new Vector2 (-2, 3);

		//Instantiate (seina);*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
