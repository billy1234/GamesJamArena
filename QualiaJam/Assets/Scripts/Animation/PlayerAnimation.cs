using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour
{
	private Animator anim;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	public void walk()
	{
		anim.SetBool("canWalk", true);
		anim.SetBool("canAttack", false);
	}
	
	public void attack()
	{
		anim.SetBool("canWalk", false);
		anim.SetBool("canAttack", true);
	}
	
	public void idle()
	{
		anim.SetBool("canWalk", false);
		anim.SetBool("canAttack", false);
		anim.SetBool("takeDamage", false);
	}
	
	public void damageTaken()
	{
		anim.SetBool("takeDamage", true);
		anim.SetBool("canWalk", false);
		anim.SetBool("canAttack", false);
	}
}
