using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
abstract public class BaseMove : MonoBehaviour
{
	protected Rigidbody rb;
	public float speed;
	public delegate void AnimationEvent();
	protected AnimationEvent onWalk,onStill;
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}

	protected void move(Vector3 direction, float speed)//do we need to pass speed
	{

		if(direction == Vector3.zero)
		{
			runEvent(onStill);
			return;
		}

		rb.MovePosition(transform.position + (direction * speed * Time.deltaTime * 100));//100 so the inspector numb isnt spatic
		runEvent(onWalk);
	}

	protected void rotate(float angle)
	{
		transform.Rotate(0,angle,0);
	}

	void runEvent(AnimationEvent delegateEvent)
	{
		if(delegateEvent != null)
		{
			delegateEvent();
		}
	}
	
}
