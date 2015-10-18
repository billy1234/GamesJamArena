using UnityEngine;
using System.Collections;

public class MinionSpawner : MonoBehaviour 
{
	public Transform[] spawnLocations;
	public int spawnAmount;
	public int spawnDelay;
	public int periodicDelay;
	public GameObject minion;
	public GameObject portals;
	// Use this for initialization
	void Awake () 
	{
		StartCoroutine(perodicSpawn());
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
	
	private IEnumerator perodicSpawn()
	{	
		while(Application.isPlaying == true)
		{
			StartCoroutine(spawnMinions());
			yield return new WaitForSeconds(periodicDelay);
		}
	}
}
