﻿using UnityEngine;
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

	/*
	void Update () 
	{
		checkHealth();
	}


	private void checkHealth()this is inside of the take dmg function now
	{
		if(health <= 0)
		{
			death ();
		}	
	}
	*/

	public virtual void takeDamage(int damageAmount)
	{
		health -= Mathf.Abs(damageAmount);
		if(health <= 0)
		{
			death ();
		}
	}

	protected virtual void death()//IF PLAYER DO SUM SHITE
	{
		print (this+" has Died");
		BaseAi myAI = gameObject.GetComponent<BaseAi>();
		if(myAI != null)
		{
			myAI.StopAllCoroutines();
		}
		gameObject.SetActive(false);
	}
}
