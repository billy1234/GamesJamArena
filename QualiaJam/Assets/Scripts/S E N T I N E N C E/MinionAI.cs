using UnityEngine;
using System.Collections;

public class MinionAI : BaseAi 
{
	protected override void Awake ()
	{
		print ("Ran");
		XboxControler[] player = GameObject.FindObjectsOfType<XboxControler>();
		target = player[Random.Range(0,player.Length)].transform;
		base.Awake ();
	}
}
