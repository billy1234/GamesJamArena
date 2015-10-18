using UnityEngine;
using System.Collections;

public class WinCheck : MonoBehaviour 
{

	BossAI[] baws;
	public GameObject youWinUi;
	void Awake()
	{
		baws = GameObject.FindObjectsOfType<BossAI>();
		youWinUi.SetActive(false);
	}

	IEnumerator checkWin()
	{
		while(youWinUi.activeSelf == false)
		{
			bool noneLeft = true;
			for(int i =0; i < baws.Length; i++)
			{

				if(baws[i].gameObject.activeSelf == true)
				{
					noneLeft = false;
				}
			}
			if(noneLeft)
			{
				youWinUi.SetActive(true);
			}

			yield return new WaitForSeconds(3f);
		}
	}
}
