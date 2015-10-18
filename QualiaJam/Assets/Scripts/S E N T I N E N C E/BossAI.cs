using UnityEngine;
using System.Collections;

[System.Serializable]
public struct exitTimes
{
	public int meleExitTime;
	public int vunrableExitTime;
	public int rangedExitTime;
}
[RequireComponent(typeof(BossHeath))]
[RequireComponent(typeof(FireHoming))]
public class BossAI : BaseAi
{
	protected BossHeath myHp;
	protected int timeTillExit =10;
	public exitTimes sateDurations;
	public float turnSpeed;
	public float projectileMaxAngle;
	private FireHoming myFire;
	public float rangedMinDistance =5f;
	protected override void Awake()
	{
		base.Awake();
		myHp = GetComponent<BossHeath>();
		state = AISTATE.RANGED;
		myFire = GetComponent<FireHoming>();
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
		case AISTATE.RANGED:
			//print (Vector3.Distance(transform.position, target.position));
			if(Vector3.Distance(transform.position, target.position) >rangedMinDistance)
			{
				myAgent.Stop();
				LookAt(target.position);
				myFire.target = target;
				myFire.fire();


			}
			else
			{
				print ("im gosu dat kite");
				myAgent.SetDestination((transform.position - target.position).normalized *5f);
			}
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
					if(Random.Range(0,2) == 0)
					{
						state = AISTATE.VUNRABLE;
						timeTillExit = sateDurations.vunrableExitTime;
					}
					else
					{
					state = AISTATE.RANGED;
					timeTillExit = sateDurations.rangedExitTime;
					}
					break;
				case AISTATE.VUNRABLE:
				print ("switched To mele");
					myHp.vunrable = false;
					state = AISTATE.MELE;
					timeTillExit = sateDurations.meleExitTime;
					break;
			case AISTATE.RANGED:
				myHp.vunrable = false;
				state = AISTATE.MELE;
				timeTillExit = sateDurations.meleExitTime;
				break;
			}
			
		}
	}

	void LookAt (Vector3 position)//rotation copy pasta
	{
		// Where we want to go
		Quaternion rotation = Quaternion.LookRotation(position - transform.position);
		// Move slowly from our rotation to the rotation we want to go to by the damping slowness
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * turnSpeed);
	}

	void getNewRandomTarget()
	{
		XboxControler[] players = GameObject.FindObjectsOfType<XboxControler>();

		target = players[Random.Range(0,players.Length)].transform;
	}
}
