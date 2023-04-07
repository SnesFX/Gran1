using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class CountKeys : MonoBehaviour
{
	public int keys;

	public GameObject keyCounterParent;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		keyCounterParent.GetComponent<Text>().text = keys.ToString();
	}

	public virtual void countUpkeys()
	{
		keys++;
	}

	public virtual void countDownkeys()
	{
		keys--;
	}
}
