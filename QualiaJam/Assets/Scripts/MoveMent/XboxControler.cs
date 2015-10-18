using UnityEngine;
using System.Collections;
public enum PLAYER
{
	PLAYER1,PLAYER2
};
[RequireComponent(typeof(FireProjectile))]
public class XboxControler : AnimatedMove
{
	public PLAYER player;
	public float turnSpeed =5f;
	private FireProjectile myProjectile;

	protected override void Awake()
	{
		base.Awake();
		myProjectile = gameObject.GetComponent<FireProjectile>();
	}

	void Update () 
	{
		switch(player)
		{
			case PLAYER.PLAYER1:
				player1Input();
			break;

			case PLAYER.PLAYER2:
				player2Input();
			break;
		}
	}

	void player1Input()
	{
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxis("L_YAxis_1");
		direction.x = -Input.GetAxis("L_XAxis_1");
		move(transform.rotation * direction, speed);
		rotate(Input.GetAxis("R_XAxis_1") * turnSpeed);
		float maymay =Input.GetAxis("TriggersR_1");
		if(maymay != 0)
		{

			//print(Input.GetAxis("TriggersR_1" )+ this.name);
			myProjectile.fire();
		}
	}

	void player2Input()
	{
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxis("L_YAxis_2");
		direction.x = -Input.GetAxis("L_XAxis_2");
		move(transform.rotation * direction, speed);
		rotate(Input.GetAxis("R_XAxis_2") * turnSpeed);
		float maymay =Input.GetAxis("TriggersR_2");
		if(maymay != 0)
		{
			//print (maymay + this.name);
			//print(Input.GetAxis("TriggersR_2")+ this.name);
			myProjectile.fire();
		}
	}
}
