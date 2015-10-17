using UnityEngine;
using System.Collections;

public class ProjectileCollision : DamageOnCollision
{	
	protected override void onCollide (GameObject other)
	{
		base.onCollide (other);
		Destroy(gameObject);
	}
}
