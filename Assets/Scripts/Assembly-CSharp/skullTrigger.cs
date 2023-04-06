using UnityEngine;

public class skullTrigger : MonoBehaviour
{
	public GameObject skull;

	public bool skullFallen;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !skullFallen)
		{
			skullFallen = true;
			((Rigidbody)skull.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
		}
	}
}
