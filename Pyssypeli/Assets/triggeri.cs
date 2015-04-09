using UnityEngine;
using System.Collections;
using System.Threading;

public class triggeri : MonoBehaviour {
	public GameObject tmp;
	pakotusovi tmp1;
	// Use this for initialization
	void Start () {
		tmp1 = (pakotusovi) tmp.GetComponentInChildren<pakotusovi>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D fucku){
	
			if (fucku.GetComponent<Collider2D>().tag == "Player") {
			//Debug.Log ("asdi")
			tmp1.vittuovi = false;
		}

	}
	void OnTriggerExit2D(Collider2D fucku)
	{


		if (fucku.GetComponent<Collider2D>().tag == "Player") {

			tmp1.vittuovi = true;
		}
	}
}

