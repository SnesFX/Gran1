using UnityEngine;

public class GrannyCloseSensor : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEye;

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			granny.gameObject.GetComponent<Collider>().enabled = true;
			((EnemyEye)grannyEye.GetComponent(typeof(EnemyEye))).enabled = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = false;
			base.gameObject.SetActive(value: false);
		}
	}
}
