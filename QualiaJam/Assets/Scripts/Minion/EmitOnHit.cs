using UnityEngine;
using System.Collections;

public class EmitOnHit : DamageOnCollision
{
	public GameObject particleDeath;

	protected override void onCollide (GameObject other)
	{	
		if(other.gameObject.tag == "Player")
		{
			base.onCollide (other);
			particleDeath.SetActive(true);
		}
	}
}
