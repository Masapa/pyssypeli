using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas playMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {

		playMenu = playMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		playMenu.enabled = false;
	}

	public void playPress()
	{
		playMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress()
	{
		playMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;

	}

	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	
	// Update is called once per frame
	void Update () {

	
	}
}
