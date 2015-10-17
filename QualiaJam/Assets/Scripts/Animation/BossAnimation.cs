using UnityEngine;
using System.Collections;

public class BossAnimation : MonoBehaviour 
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
		anim.SetBool("canAoE", false);
		anim.SetBool("canVulnerable", false);
	}
	
	public void attack()
	{
		anim.SetBool("canAttack", true);
		anim.SetBool("canAoE", false);
		anim.SetBool("canVulnerable", false);
		anim.SetBool("canWalk", false);
	}
	
	public void vulnerable()
	{
		anim.SetBool("canVulnerable", true);
		anim.SetBool("canWalk", false);
		anim.SetBool("canAttack", false);
		anim.SetBool("canAoE", false);
	}
	
	public void areaOfEffect()
	{
		anim.SetBool("canAoE", true);
		anim.SetBool("takeVulnerable", false);
		anim.SetBool("canWalk", false);
		anim.SetBool("canAttack", false);
	}
}
