using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour 
{
	public GameObject projectile;
	public float fireSpeed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			fire();
		}
	}
	
	private void fire()
	{
		Vector3 mosPos = Input.mousePosition;
		mosPos.z += 10f;
		Vector3 currentPos = Camera.main.ScreenToWorldPoint(mosPos);
	
		GameObject bulletInstance = Instantiate(projectile, currentPos, Quaternion.identity) as GameObject;
		bulletInstance.GetComponent<ProjectileMove>().speed += fireSpeed;
	}
}
