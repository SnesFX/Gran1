using UnityEngine;

public class crowArrowShot : MonoBehaviour
{
	public GameObject crow;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "arrow")
		{
			((CrowControl)crow.GetComponent(typeof(CrowControl))).shootInBur = true;
		}
	}
}
