﻿using UnityEngine;
using System.Collections;
public enum PLAYER
{
	PLAYER1,PLAYER2
};
public class PlayerMoveXbox : BaseMove
{
	public PLAYER player;
	public float turnSpeed =5f;

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
		transform.Rotate(0,Input.GetAxis("R_XAxis_1") * turnSpeed,0);
	}
	void player2Input()
	{
		Vector3 direction = Vector3.zero;
		direction.z = Input.GetAxis("L_YAxis_2");
		direction.x = -Input.GetAxis("L_XAxis_2");
		move(transform.rotation * direction, speed);
		transform.Rotate(0,Input.GetAxis("R_XAxis_2") * turnSpeed,0);
	}
}
