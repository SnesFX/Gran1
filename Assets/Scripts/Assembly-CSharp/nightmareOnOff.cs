using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class nightmareOnOff : MonoBehaviour
{
	public bool NightmareOnOff;

	private Toggle m_Toggle;

	public virtual void Start()
	{
		m_Toggle = GetComponent<Toggle>();
		m_Toggle.onValueChanged.AddListener(delegate
		{
			ToggleValueChanged(m_Toggle);
		});
		if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
		{
			m_Toggle.GetComponent<Toggle>().isOn = false;
		}
		else if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
		}
	}

	public virtual void Update()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 0)
		{
			m_Toggle.GetComponent<Toggle>().isOn = false;
		}
		else
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
		}
	}

	private void ToggleValueChanged(Toggle change)
	{
		if (m_Toggle.isOn)
		{
			m_Toggle.GetComponent<Toggle>().isOn = true;
			PlayerPrefs.SetInt("NightMareOnOff", 1);
		}
		else
		{
			NightmareOnOff = true;
			m_Toggle.GetComponent<Toggle>().isOn = false;
			PlayerPrefs.SetInt("NightMareOnOff", 0);
		}
	}
}
