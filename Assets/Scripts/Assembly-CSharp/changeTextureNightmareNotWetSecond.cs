using UnityEngine;

public class changeTextureNightmareNotWetSecond : MonoBehaviour
{
	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	private void Start()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			GetComponent<Renderer>().materials[1].mainTexture = nightmareTexture;
		}
		else
		{
			GetComponent<Renderer>().materials[1].mainTexture = normalTexture;
		}
	}
}
