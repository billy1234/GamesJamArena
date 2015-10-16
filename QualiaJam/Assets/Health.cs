using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
	public int maxHealth;
	private int health;
	// Use this for initialization
	void Start () 
	{
		health += maxHealth;
	}
	
	// Update is called once per frame
	void Update () 
	{
		checkHealth();
	}
	
	private void checkHealth()
	{
		if(health <= 0)
		{
			death ();
		}	
	}
	
	public void takeDamage(int damageAmount)
	{
		health -= damageAmount;
	}
	
	protected virtual void death()
	{
		print ("Player Died");
	}
}
