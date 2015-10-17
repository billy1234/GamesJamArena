using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour 
{
	public Material tiledTexture;
	public float scrollSpeed;

	void Update () 
	{
		scrollTexture();
	}
	
	private void scrollTexture()
	{
		float offSet = Time.time * scrollSpeed;
		tiledTexture.mainTextureOffset = new Vector2(offSet,0);
	}
	
	
}
