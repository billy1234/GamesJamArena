using UnityEngine;
using System.Collections;

public class HomingMove : ProjectileMove
{
	public Transform target;

	protected override void FixedUpdate()
	{

		rb.velocity = (target.position  -transform.position ).normalized *speed;
	}
}
