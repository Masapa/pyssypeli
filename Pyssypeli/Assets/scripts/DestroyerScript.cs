using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	// Use this for initialization

	void  OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Application.LoadLevel(1);
			Debug.Break();

			return;
		}


		if(other.gameObject.transform.parent.gameObject)

		{
			Destroy(other.gameObject.transform.parent.gameObject);

		}

		else
		{

	       Destroy(other.gameObject);


		}




	}

	





}
