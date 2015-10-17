using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
abstract public class BaseMove : MonoBehaviour
{
	protected Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () 
	{
		rb = this.gameObject.GetComponent<Rigidbody>();
	}

	protected void move(Vector3 direction, float speed)//do we need to pass speed
	{
			//CLMAP directon BASED ON velocitys mag
		if(direction == Vector3.zero)
			return;

		rb.MovePosition(transform.position + (direction * speed * Time.deltaTime * 100));//100 so the inspector numb isnt spatic

	}

	protected void rotate(float angle)
	{
		transform.Rotate(0,angle,0);
	}
	
}
