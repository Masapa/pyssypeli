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
	public float hp = 6;

	void OnTriggerEnter2D(){
		hp -= bullet.Damage;
	}


	void Death(){
		Destroy (gameObject);
	}
	
	// Use this for initialization
	void Start () 
	{
		//GameObject Bullet = GameObject.Find ("Bullet");
		//Bullet damage = Bullet.GetComponent<Bullet> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (hp <= 0)
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
