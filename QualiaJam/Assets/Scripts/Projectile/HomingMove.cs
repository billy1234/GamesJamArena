using UnityEngine;
using System.Collections;

public class HomingMove : ProjectileMove
{
	public Transform target;

	protected override void FixedUpdate()
	{
		rb.AddForce((target.position  -transform.position ).normalized *speed,ForceMode.Force);
	}
}
