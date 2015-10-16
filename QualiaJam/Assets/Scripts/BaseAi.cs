using UnityEngine;
using System.Collections;
public enum AISTATE
{
	MELE
};
[RequireComponent(typeof(NavMeshAgent))]
public class BaseAi : MonoBehaviour 
{
	public float brainUpdateRate =1f;
	protected AISTATE state = AISTATE.MELE;
	protected NavMeshAgent myAgent;
	public Transform target;


	void Awake ()
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
		switch(state)
		{
			case AISTATE.MELE:
				//print ("IN MELE");
				myAgent.SetDestination(target.position);
				break;

		}
	}

}
