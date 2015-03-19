using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary; // Muuttaa datan binaarimuotoon
using System.IO;

public static class SaveLoad
{
	public static List<Game> savedGame = new List<Game>();

	public static void Save()
	{
		savedGame.Add (Game.current);
		BinaryFormatter bf = new BinaryFormatter (); // Serialization funktio
		FileStream file = File.Create (Application.persistentDataPath + "/savedGames.pp");
		/* peristentDataPath on Unityn oma sisäänrakennettu varasto pelitiedostoille.
		 * Se päivittyy alustan mukaan
		*/
		bf.Serialize (file, SaveLoad.savedGame);
		file.Close ();

	}

	public static void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/savedGames.pp")) 
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/savedGames.pp", FileMode.Open);
			SaveLoad.savedGame = (List<Game>)bf.Deserialize(file); // Muutetaan binaari takaisin haluamaamme muotoon (List)
			file.Close ();
		}

	}	
}