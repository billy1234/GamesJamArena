using UnityEngine;
using System.Collections;

public class BossHeath : Health
{
	public 	bool vunrable;

	public override void takeDamage (int damageAmount)
	{
		if(vunrable)
		{
			damageAmount = damageAmount * 2;
		}
		base.takeDamage (damageAmount);//double damage
	}
}
