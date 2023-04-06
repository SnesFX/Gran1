using System;
using UnityEngine;

[Serializable]
public class OrbGizmo : MonoBehaviour
{
	public virtual void Start()
	{
		MonoBehaviour.print("Orb count: " + base.transform.childCount);
	}

	public virtual void OnDrawGizmos()
	{
		if (!base.enabled)
		{
			return;
		}
		foreach (Transform item in base.transform)
		{
			Gizmos.DrawIcon(item.position, "particleGizmo.tif");
		}
	}
}
