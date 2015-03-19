using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Mappigene : MonoBehaviour {
	public int x = 3;
	public int y = 3;

	List<List<GameObject>> testi = new List<List<GameObject>>();
	public GameObject testii2;
	//float pituus = ;
	// Use this for initialization
	int a;
	float nextx;
	float pituus;
	float nexty;
	void Start () {
		pituus = testii2.transform.gameObject.GetComponent<SpriteRenderer> ().bounds.extents.x;
		Debug.Log ("Vittu se on" + pituus);
		nexty = 0;
		for (int i = 0; i<y; i++) {
			testi.Add (new List<GameObject>());
			nextx = 0;
			for(a = 0;a<x;a++){
				testi[i].Add ((GameObject)Instantiate(testii2));
				if(i+1%3==1&&a%2 == 0){nextx = pituus;testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,30);nextx +=pituus*1.5f;}
				if(i+1%3==1&&a%2 == 1){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,180-30);nextx += pituus*2;}

				if(i+1%3==2){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,90);nextx +=pituus*4;}


				if(i+1%3==0&&a%2 == 0){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,30);nextx +=testi[i][a].transform.gameObject.GetComponent<SpriteRenderer> ().bounds.size.x-0.5f;}
				if(i+1%3==0&&a%2 == 1){testi[i][a].transform.position = new Vector2(nextx,nexty); testi[i][a].transform.Rotate(0,0,180-30);nextx += testi[i][a].transform.gameObject.GetComponent<SpriteRenderer> ().bounds.size.x;}

				
			}


			nexty -= pituus*1.5f;
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
