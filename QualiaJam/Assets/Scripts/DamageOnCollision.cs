using UnityEngine;
using System.Collections;

public class DamageOnCollision : MonoBehaviour
{
	public int damage;
	public bool knockBack;
	public float knockBackForce;

	void OnCollisionEnter(Collision col)
	{
		Health other = col.gameObject.GetComponent<Health>();
		if(other != null)
		{
			other.takeDamage(damage);
			if(knockBack)
			{
				Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
				if(rb != null)
				{
					rb.AddForce((col.gameObject.transform.position - transform.position).normalized * knockBackForce,ForceMode.Impulse);
				}
			}
		}
		//bounce him back

	}
}
