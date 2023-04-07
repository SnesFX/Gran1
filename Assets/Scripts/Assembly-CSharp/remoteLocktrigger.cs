using UnityEngine;

public class remoteLocktrigger : MonoBehaviour
{
	public bool playerNearDoorLock;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			playerNearDoorLock = true;
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			playerNearDoorLock = false;
		}
	}
}
