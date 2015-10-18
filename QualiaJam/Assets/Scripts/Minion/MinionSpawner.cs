using UnityEngine;
using System.Collections;

public class MinionSpawner : MonoBehaviour 
{
	public Transform[] spawnLocations;
	public int spawnAmount;
	public int spawnDelay;
	public GameObject minion;
	public GameObject portals;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(spawnMinions());
	}

	private IEnumerator spawnMinions()
	{
		portals.SetActive(true);
		
		for(int i = 0; i < spawnLocations.Length; i++)
		{
			for(int x = 0; x < spawnAmount; x++)
			{
				yield return new WaitForSeconds(spawnDelay);
				Instantiate(minion,spawnLocations[i].position,Quaternion.identity);
			}
		}
		
		portals.SetActive(false);
	}
}
