using UnityEngine;
using System.Collections;

public class ProjectileMove : BaseMove
{
	protected virtual void FixedUpdate () 
	{
		move(-transform.forward, speed);
	}
}
