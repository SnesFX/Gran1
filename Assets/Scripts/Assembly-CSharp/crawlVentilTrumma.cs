using System;
using UnityEngine;

[Serializable]
public class crawlVentilTrumma : MonoBehaviour
{
	public GameObject granny;

	public GameObject grannyEyes;

	public GameObject crouchButton;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = true;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
			grannyEyes.SetActive(value: false);
			crouchButton.SetActive(value: false);
		}
	}

	public virtual void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerInHole = false;
			((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).playerHiding = false;
			grannyEyes.SetActive(value: true);
			crouchButton.SetActive(value: true);
		}
	}
}
