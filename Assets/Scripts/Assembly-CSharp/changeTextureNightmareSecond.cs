using UnityEngine;

public class changeTextureNightmareSecond : MonoBehaviour
{
	public Texture2D normalTexture;

	public Texture2D nightmareTexture;

	private void Start()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			GetComponent<Renderer>().materials[1].mainTexture = nightmareTexture;
			GetComponent<Renderer>().material.SetFloat("_Metallic", 0.15f);
			GetComponent<Renderer>().material.SetFloat("_Glossiness", 0.95f);
		}
		else
		{
			GetComponent<Renderer>().materials[1].mainTexture = normalTexture;
		}
	}
}
