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

	protected virtual void move(Vector3 direction, float speed)
	{
		rb.AddForce(direction * speed);
	}
}
