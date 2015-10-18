using UnityEngine;
using System.Collections;


public class AnimatedMove : BaseMove
{
	public PlayerAnimation myAnim;
	protected virtual void Awake()
	{
		onWalk += animateWalk;
		onStill += enterIdle;
	}

	void animateWalk()
	{
		myAnim.walk();
	}

	void enterIdle()
	{
		myAnim.idle();
	}
}
