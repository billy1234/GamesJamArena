using UnityEngine;
using System.Collections;

public class DamageOnCollision : MonoBehaviour
{
	public int damage;
	public bool knockBack;
	public float knockBackForce;
	public float disableTime;
	private void OnCollisionEnter(Collision col)
	{

		onCollide(col.gameObject);

	}

	protected virtual void onCollide(GameObject other)
	{
		Health otherHp = other.gameObject.GetComponent<Health>();
		if(otherHp != null)
		{
			otherHp.takeDamage(damage);
			if(knockBack)
			{
				Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
				if(rb != null)
				{
					rb.velocity = Vector3.zero;
					rb.AddForce((other.gameObject.transform.position - transform.position).normalized * knockBackForce,ForceMode.Impulse);
					XboxControler player = other.GetComponent<XboxControler>();
					if(player != null)
					{
						StartCoroutine(disable(player));
					}
				}
			}
		}
	}

	IEnumerator disable(XboxControler player)
	{
		player.enabled = false;
		yield return new WaitForSeconds(disableTime);
		player.enabled = true;
	}
}
