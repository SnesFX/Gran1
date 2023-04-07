using UnityEngine;

public class PepperSprayHit : MonoBehaviour
{
	public GameObject granny;

	public GameObject GrannyClosetrigger;

	private void OnParticleCollision(GameObject other)
	{
		if (other.tag == "granny")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hitByPepper = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).hitByPepperStart = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).grannyPepperReact = false;
			GrannyClosetrigger.SetActive(value: true);
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).blindTimer = 30f;
		}
	}
}
