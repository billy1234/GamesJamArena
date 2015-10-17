using UnityEngine;
using System.Collections;


public class FireProjectile : MonoBehaviour 
{
	public GameObject projectile;
	public float fireSpeed;
	public Transform hand;
	protected bool canFire = true;
	public float fireRate =3f;


	public void fire()
	{
		if(canFire)
		{
			GameObject bulletInstance = Instantiate(projectile, hand.position, transform.rotation) as GameObject;
			bulletInstance.GetComponent<ProjectileMove>().speed += fireSpeed;
			StartCoroutine(coolDown());
		}
	}

	private IEnumerator coolDown()
	{
		canFire = false;
		yield return new WaitForSeconds(fireRate);
		canFire = true;
	}
}
