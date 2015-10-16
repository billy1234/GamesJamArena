using UnityEngine;
using System.Collections;

public class ProjectileMove : BaseMove
{
	void Update () 
	{
		base.move(-transform.forward, speed);
	}
}
