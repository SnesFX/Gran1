using UnityEngine;

public class changeTextureNightmareNotWet : MonoBehaviour
{
	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	private void Start()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			GetComponent<Renderer>().material.mainTexture = nightmareTexture;
		}
		else
		{
			GetComponent<Renderer>().material.mainTexture = normalTexture;
		}
	}
}
