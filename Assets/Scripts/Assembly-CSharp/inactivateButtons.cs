using System;
using UnityEngine;

[Serializable]
public class inactivateButtons : MonoBehaviour
{
	public GameObject forwardButton;

	public GameObject backButton;

	public GameObject startButton;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			forwardButton.SetActive(value: false);
			backButton.SetActive(value: false);
			startButton.SetActive(value: false);
		}
	}
}
