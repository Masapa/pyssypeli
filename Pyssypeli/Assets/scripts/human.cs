using UnityEngine;
using System.Collections;

public class human : MonoBehaviour 

{

		private string characterClass ;
		private int level ;
		private string characterName ;
		private int energy ;
		private int money ;
		private float locationX ;
		private float locationY ;
		private int agility ;
		private int constitution ;
		private int luck ;
		private int strength ;
		private string special ;
		private string[] inventory ;
		private bool isAlive ;
		private bool isHostile ;

	public BulletScript bullet;
	public float health = 6;

	void OnTriggerEnter2D(){
		health -= bullet.Damage;
	}


	void Death(){
		if (health <= 0)
		Destroy (gameObject);
	}
	
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
			Death ();
	}
	
	public void moveUp()
	{
	
	}
	public void moveDown()
	{
	
	}
	public void moveLeft()
	{
	
	}
	public void moveRight()
	{
	
	}
	public void attackMelee()
	{
	
	}
	public void attackWeapon()
	{
	
	}
	public void block()
	{
	
	}
	public void dropItem()
	{
	
	}
	public void killCharacter()
	{
	
	}

}
