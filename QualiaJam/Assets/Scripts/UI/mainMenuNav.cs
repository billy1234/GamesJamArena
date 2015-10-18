using UnityEngine;
using System.Collections;

public class mainMenuNav : MonoBehaviour 
{
	void Update () 
	{
		if(Input.GetAxis("A_1") > 0)
		{
			Application.LoadLevel(1);
		}
	}
}
