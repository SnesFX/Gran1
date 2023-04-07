using UnityEngine;

public class checkSprayCounter : MonoBehaviour
{
	public GameObject sprayEmptyText;

	public float sprayCounter = 5f;

	public bool textTimerOnOff;

	public float textTimer;

	private void Start()
	{
	}

	public virtual void Update()
	{
		if (textTimerOnOff)
		{
			textTimer += Time.deltaTime;
			if (textTimer > 3f)
			{
				textTimerOnOff = false;
				textTimer = 0f;
				sprayEmptyText.SetActive(value: false);
			}
		}
	}

	public virtual void checkingSpray()
	{
		textTimer = 0f;
		sprayEmptyText.SetActive(value: true);
		textTimerOnOff = true;
	}
}
