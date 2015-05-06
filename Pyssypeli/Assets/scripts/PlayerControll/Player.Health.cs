using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {
	
	public Slider healthSlider;							// Reference to the UI's health bar.
	public float flashSpeed = 5f;
	public int startingHealth = 100;
	public float health;
	public Image damageImage;
	public Color flashColour = new Color (1f, 0f, 0f, 0.1f);

	public float resetAfterDeathTime = 5f;              // How much time from the player dying to the level reseting.
	private float timer;		                        // A timer for counting to the reset of the level once the player is dead.
	private bool damaged;
	private bool playerDead;                            // A bool to show if the player is dead or not.
	private Movement playerMovement;              		// Reference to the player movement script.
	private HashIDs hash;                               // Reference to the HashIDs.             
	private LastPlayerSighting lastPlayerSighting;      // Reference to the LastPlayerSighting script.



	void StartLife (){
		health = startingHealth;
	}

	void DeathCheck (){
		if (health <= 0)
			playerDead = true;
	}
	
	
	void PlayerDied(){
		// The player is now dead.
		playerDead = true;
	}
	
	
	void PlayerDead ()
	{
		playerMovement.enabled = false;
		lastPlayerSighting.position = lastPlayerSighting.resetPosition;
		playerDead = true;
	}
	
	
	void LevelReset ()
	{
		Application.LoadLevel(1);
	}


	void testaus ()
	{
		// If the player has just been damaged...
		if(damaged)
		{
			// ... set the colour of the damageImage to the flash colour.
			damageImage.color = flashColour;
		}
		// Otherwise...
		else
		{
			// ... transition the colour back to clear.
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		
		// Reset the damaged flag.
		damaged = false;
	}

	public void TakeDamage (int d)
	{
		// Set the damaged flag so the screen will flash.
		damaged = true;

		// Reduce the current health by the damage amount.
		health -= d;
		
		// Set the health bar's value to the current health.
		healthSlider.value = health;

		//damaged = false;
	}



}
