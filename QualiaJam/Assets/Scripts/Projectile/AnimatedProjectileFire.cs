using UnityEngine;
using System.Collections;

public class AnimatedProjectileFire : FireProjectile
{
	public PlayerAnimation player;
	void Start ()
	{
		onFire += animateFire;
	}

	void animateFire()
	{
		player.attack();
	}


}
