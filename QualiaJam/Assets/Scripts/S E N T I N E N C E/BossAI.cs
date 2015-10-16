using UnityEngine;
using System.Collections;


[RequireComponent(typeof(BossHeath))]
public class BossAI : BaseAi
{
	protected BossHeath myHp;
	public float vunrableTime =3f;
	protected float timeTillExit =0f;

	void Awake()
	{
		myHp = GetComponent<BossHeath>();
	}

	protected override void decision ()
	{
		switch(state)
		{
		case AISTATE.MELE:
			//print ("IN MELE");
			myAgent.SetDestination(target.position);
			break;
		case AISTATE.VUNRABLE:
			//need visual feedback
			myHp.vunrable = true;
			myAgent.Stop();
				break;
			
		}
	}

	protected void exitConditions()
	{
		timeTillExit -= Time.deltaTime;//lol this isnt legit at all
		switch(state)
		{
			case AISTATE.MELE:
				//print ("IN MELE");
				myAgent.SetDestination(target.position);
				break;
			case AISTATE.VUNRABLE:
				//need visual feedback
				myHp.vunrable = true;
				myAgent.Stop();
				break;
			
		}
	}
}
