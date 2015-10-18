using UnityEngine;
using System.Collections;

public class FireHoming :FireProjectile
{
	public Transform target;
	public override void fire ()
	{
		if(canFire)
		{
			if(onFire != null)
			{
				onFire();
			}
			GameObject bulletInstance = Instantiate(projectile, hand.position, transform.rotation) as GameObject;
			bulletInstance.GetComponent<HomingMove>().speed += fireSpeed;
			bulletInstance.GetComponent<HomingMove>().target = target;
			StartCoroutine(coolDown());
			StartCoroutine(shakeCam());
		}
	}

}
