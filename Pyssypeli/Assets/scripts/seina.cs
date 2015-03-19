using UnityEngine;
using System.Collections;

public class seina : MonoBehaviour {
	public bool kulma = false; // onko kulmassa vai suorassa;
	public bool oikea = false; // kulma oikeaan vai vasempaan;
	public bool ala = false;
	// Use this for initialization
	void Start () {
		if (!ala && kulma && !oikea)
			transform.Rotate (0, 0, 60);
		if (oikea && kulma && !ala)
			transform.Rotate (0, 0, 60 + 60 + 60 + 60 + 60);
		if (ala && oikea && kulma)
			transform.Rotate (0, 0, 60 + 60);
		if (ala && !oikea && kulma)
			transform.Rotate (0, 0, 60 + 60 + 60 + 60);
		if (!kulma) {
			transform.Rotate (0, 0, 0);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
