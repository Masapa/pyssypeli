using UnityEngine;
using System.Collections;

[System.Serializable]
public class Game
{
	public static Game current;
	// Ei vielä ole hahmoluokkia joten nimetty Char1...4
	public Character char1;
	public Character char2;
	public Character char3;
	public Character char4;

	public Game()
	{
		char1 = new Character ();
		char2 = new Character ();
		char3 = new Character ();
		char4 = new Character ();
	}


}