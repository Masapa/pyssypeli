using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public partial class Player : MonoBehaviour {
	
	public float startingHealth = 100;
	public float health;
	public Slider healthSlider;							// Reference to the UI's health bar.
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color (1f, 0f, 0f, 0.1f);
	
	
	public float resetAfterDeathTime = 5f;              // How much time from the player dying to the level reseting.                    
	private Movement playerMovement;              		// Reference to the player movement script.
	private HashIDs hash;                               // Reference to the HashIDs.             
	private LastPlayerSighting lastPlayerSighting;      // Reference to the LastPlayerSighting script.
	private float timer;                                // A timer for counting to the reset of the level once the player is dead.
	private bool damaged;
	private bool playerDead;                            // A bool to show if the player is dead or not.
	
	
	
	void bullshit ()
	{
		/*
		// Setting up the references.
		playerMovement = GetComponent<Movement>();
		hash = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<HashIDs>();
		lastPlayerSighting = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<LastPlayerSighting>();
		
		// setting starting health to the player*/
		health = startingHealth;
	}

	
	
	
	void PlayerDying(){
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
	
	
	public void TakeDamage (float amount)
	{
		// Set the damaged flag so the screen will flash.
		damaged = true;
		
		// Reduce the current health by the damage amount.
		health -= amount;
		
		// Set the health bar's value to the current health.
		healthSlider.value = health;
		
		/*
		// If the player has lost all it's health and the death flag hasn't been set yet...
		if(health <= 0)
		{
			// ... it should die.
			PlayerDead();
			//LevelReset();
		}*/
		
	}



}
