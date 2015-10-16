using UnityEngine;
using System.Collections;

public class PlayerMove : BaseMove 
{
	void Update()
	{
		debugControls();
	}
	
	private void debugControls()
	{
		if(Input.GetKey(KeyCode.W))
		{
			move(Vector3.forward, speed);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			move(-Vector3.forward, speed);
		}
		if(Input.GetKey(KeyCode.A))
		{
			move(-Vector3.right, speed);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			move(Vector3.right, speed);
		}
	}
	
}
