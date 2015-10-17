using UnityEngine;
using System.Collections;

public class MinionSpawner : MonoBehaviour 
{
	public Transform[] spawnLocations;
	public int spawnAmount;
	public GameObject minion;
	// Use this for initialization
	void Start () 
	{
		spawnMinions();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void spawnMinions()
	{
		for(int i = 0; i < spawnLocations.Length; i++)
		{
			for(int x = 0; x < spawnAmount; x++)
			{
				StartCoroutine(createMinion(i));
			}
			
		}
	}
	
	public IEnumerator createMinion(int spawnIndex)
	{
		yield return new WaitForSeconds(2f);
		Instantiate(minion,spawnLocations[spawnIndex].position,Quaternion.identity);
	}
}
