using UnityEngine;

public class ignoreCollider : MonoBehaviour
{
	public GameObject trap;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Physics.IgnoreCollision(trap.GetComponent<Collider>(), other.GetComponent<CharacterController>(), ignore: true);
		}
	}
}
