using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class PlayerWindowController : MonoBehaviour
{
	public GameObject player;

	public GameObject granny;

	public GameObject window;

	public GameObject camIndoor;

	public GameObject camOutdoor;

	public Transform PlayerOutPos;

	public Transform PlayerInPos;

	public GameObject crouchButton;

	public GameObject holeCollider;

	public GameObject SoundOut;

	public GameObject SoundIn;

	public virtual void Start()
	{
	}

	public virtual void jumpOut()
	{
		((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		player.SetActive(value: false);
		camIndoor.SetActive(value: true);
		holeCollider.SetActive(value: true);
		window.gameObject.GetComponent<Animation>().Play("WindowOpenClose");
		camIndoor.gameObject.GetComponent<Animation>().Play("CamInToOut");
		((backgroundSound)SoundOut.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)SoundIn.GetComponent(typeof(backgroundSound))).fadeUp = true;
		StartCoroutine(playerSpawnOutside());
	}

	public virtual void jumpIn()
	{
		((EnemyAIGranny)granny.GetComponent(typeof(EnemyAIGranny))).seePlayer = false;
		player.SetActive(value: false);
		camOutdoor.SetActive(value: true);
		holeCollider.SetActive(value: true);
		window.gameObject.GetComponent<Animation>().Play("WindowOpenClose");
		camOutdoor.gameObject.GetComponent<Animation>().Play("CamOutToIn");
		((backgroundSound)SoundIn.GetComponent(typeof(backgroundSound))).fadeDown = true;
		((backgroundSound)SoundOut.GetComponent(typeof(backgroundSound))).fadeUp = true;
		StartCoroutine(playerSpawnInside());
	}

	public virtual IEnumerator playerSpawnOutside()
	{
		yield return new WaitForSeconds(2.1f);
		player.transform.position = PlayerOutPos.position;
		player.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
		player.SetActive(value: true);
		camIndoor.SetActive(value: false);
		crouchButton.SetActive(value: true);
		holeCollider.SetActive(value: false);
	}

	public virtual IEnumerator playerSpawnInside()
	{
		yield return new WaitForSeconds(1.75f);
		player.transform.position = PlayerInPos.position;
		player.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
		player.SetActive(value: true);
		camOutdoor.SetActive(value: false);
		crouchButton.SetActive(value: true);
		holeCollider.SetActive(value: false);
	}
}
