using UnityEngine;
using System.Collections;
public enum AISTATE
{
	MELE,VUNRABLE,RANGED
};
[RequireComponent(typeof(NavMeshAgent))]
public class BaseAi : MonoBehaviour 
{
	public float brainUpdateRate =1f;
	protected AISTATE state = AISTATE.MELE;
	protected NavMeshAgent myAgent;
	public Transform target;


	protected virtual void Awake ()
	{
		myAgent = GetComponent<NavMeshAgent>();
		StartCoroutine(main());
	}

	private IEnumerator main()
	{
		while(gameObject.activeSelf == true)
		{
			decision();
			yield return new WaitForSeconds(brainUpdateRate);
		}
	}

	protected virtual void decision()
	{
		switch(state)//base ai is only mele
		{
			case AISTATE.MELE:
				//print ("IN MELE");
				myAgent.SetDestination(target.position);
				break;

		}
	}

}
