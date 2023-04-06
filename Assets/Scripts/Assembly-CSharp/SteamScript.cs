using Steamworks;
using UnityEngine;

public class SteamScript : MonoBehaviour
{
	private void Start()
	{
		if (SteamManager.Initialized)
		{
			Debug.Log(SteamFriends.GetPersonaName());
		}
	}
}
