using UnityEngine;
using System.Collections;

[System.Serializable]
public struct exitTimes
{
	public int meleExitTime;
	public int vunrableExitTime;
}
[RequireComponent(typeof(BossHeath))]
public class BossAI : BaseAi
{
	protected BossHeath myHp;
	protected int timeTillExit =10;
	public exitTimes sateDurations;
	protected override void Awake()
	{
		base.Awake();
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

			myAgent.Stop();
				break;

		}
		exitConditions();
	}

	protected void exitConditions()
	{
		timeTillExit -= 1;//ai ticks till next condition
		if(timeTillExit <= 0)
		{
			switch(state)
			{
				case AISTATE.MELE:
				print ("switched To vunrable");
					myHp.vunrable = true;
					state = AISTATE.VUNRABLE;
					timeTillExit = sateDurations.vunrableExitTime;
					break;
				case AISTATE.VUNRABLE:
				print ("switched To mele");
					myHp.vunrable = false;
					state = AISTATE.MELE;
					timeTillExit = sateDurations.meleExitTime;
					break;
			}
			
		}
	}
}
