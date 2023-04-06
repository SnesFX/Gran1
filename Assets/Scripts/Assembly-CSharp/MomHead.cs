using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class MomHead : MonoBehaviour
{
	public GameObject momFaceScare;

	public bool faceReady;

	public bool faceNot;

	public GameObject ljudHolder;

	public virtual void Start()
	{
	}

	public virtual void Update()
	{
		if (faceReady && !faceNot)
		{
			faceReady = false;
			momFaceScare.SetActive(value: true);
			StartCoroutine(faceScare());
		}
	}

	public virtual IEnumerator faceScare()
	{
		yield return new WaitForSeconds(0.1f);
		momFaceScare.SetActive(value: false);
		faceNot = true;
	}
}
