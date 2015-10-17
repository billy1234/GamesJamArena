using UnityEngine;
using System.Collections;

public class SuicideMelee : Health
{
	public int explosionDamage;
	public GameObject deathParticle;

	protected override void death ()
	{
		RaycastHit hitInfo;
		RaycastHit[] hits = Physics.SphereCastAll(this.transform.position,10f,Vector3.forward);
		
		for(int i = 0; i < hits.Length; i++)
		{
			if(hits[i].collider.gameObject.tag ==  "Player")
			{
				deathParticle.gameObject.SetActive(true);
				hits[i].collider.gameObject.GetComponent<Health>().takeDamage(explosionDamage);
			}
		}
		
		base.death ();
	}
}
