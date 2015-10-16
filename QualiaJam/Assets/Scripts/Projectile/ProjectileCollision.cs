using UnityEngine;
using System.Collections;

public class ProjectileCollision : DamageOnCollision
{	
	public override void OnCollisionEnter (Collision col)
	{
		base.OnCollisionEnter (col);
		Destroy(gameObject);
	}
}
