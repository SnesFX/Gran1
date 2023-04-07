using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SeeObjects : MonoBehaviour
{
	public GameObject handHolder;

	public virtual void Update()
	{
		Touch[] touches = Input.touches;
		for (int i = 0; i < touches.Length; i++)
		{
			Touch touch = touches[i];
			if (touch.phase == TouchPhase.Began && GetComponent<Image>().HitTest(touch.position))
			{
				((PickUp)handHolder.GetComponent(typeof(PickUp))).pickUp = true;
			}
		}
	}
}
