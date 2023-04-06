using System;
using UnityEngine;

[Serializable]
public class InvinsibleObj : MonoBehaviour
{
	public virtual void Start()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(Renderer));
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			((Renderer)componentsInChildren[i]).material.renderQueue = 2002;
		}
	}
}
