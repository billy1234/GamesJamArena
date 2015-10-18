using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class healthBar : Health
{
	public Slider healthSlider;
	
	public override void Start ()
	{
		base.Start ();
		healthSlider.maxValue += maxHealth;
	}

	public override void takeDamage (int damageAmount)
	{
		healthSlider.value -= damageAmount;
		base.takeDamage (damageAmount);
		
	}
}
