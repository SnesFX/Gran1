using UnityEngine;

public class activatePlaskTrigger : MonoBehaviour
{
	public GameObject plaskTrigger;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			plaskTrigger.SetActive(value: true);
		}
	}
}
