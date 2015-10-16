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
			move(transform.forward, speed);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			move(-transform.forward, speed);
		}
		if(Input.GetKey(KeyCode.A))
		{
			move(-transform.right, speed);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			move(transform.right, speed);
		}
	}
	
}
