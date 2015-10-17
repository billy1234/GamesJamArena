using UnityEngine;
using System.Collections;

public class HealthPickUp : MonoBehaviour
{
	public int healthBonus;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			//other.gameObject.GetComponent<Health>().addHealth(healthBonus);
		}
	}
}
