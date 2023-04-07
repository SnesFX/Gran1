using UnityEngine;

public class remoteTextScript : MonoBehaviour
{
	public GameObject needToGetCloserText;

	public bool textTimerOnOff;

	public float textTimer;

	private void Start()
	{
	}

	private void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				needToGetCloserText.SetActive(value: false);
			}
		}
	}
}
