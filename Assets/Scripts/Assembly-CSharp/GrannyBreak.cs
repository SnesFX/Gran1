using System.Collections;
using UnityEngine;

public class GrannyBreak : MonoBehaviour
{
	public GameObject parent;

	public GameObject gameController;

	public GameObject top;

	public GameObject head;

	public GameObject leftArm;

	public GameObject RightArm;

	public GameObject ChristmasHat;

	public AudioClip crashLjud;

	public bool haveBreaked;

	public float fadeStartTime;

	public virtual IEnumerator Start()
	{
		gameController = GameObject.Find("GameController");
		if (((ChristmasScript)gameController.GetComponent(typeof(ChristmasScript))).itsChristmas)
		{
			ChristmasHat.SetActive(value: true);
		}
		if (PlayerPrefs.GetInt("DiffData") == 3)
		{
			yield return new WaitForSeconds(15f);
		}
		else
		{
			yield return new WaitForSeconds(fadeStartTime);
		}
		startBrake();
		StartCoroutine(Destroytimer());
	}

	public virtual void startBrake()
	{
		if (!haveBreaked)
		{
			haveBreaked = true;
			top.transform.GetComponent<MeshCollider>().convex = true;
			((Rigidbody)top.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)head.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)leftArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)RightArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			top.transform.parent = null;
			head.transform.parent = null;
			leftArm.transform.parent = null;
			RightArm.transform.parent = null;
			GetComponent<AudioSource>().PlayOneShot(crashLjud);
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv" && !haveBreaked)
		{
			haveBreaked = true;
			top.transform.GetComponent<MeshCollider>().convex = true;
			((Rigidbody)top.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)head.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)leftArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			((Rigidbody)RightArm.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = false;
			top.transform.parent = null;
			head.transform.parent = null;
			leftArm.transform.parent = null;
			RightArm.transform.parent = null;
			GetComponent<AudioSource>().PlayOneShot(crashLjud);
		}
	}

	public virtual IEnumerator Destroytimer()
	{
		yield return new WaitForSeconds(5f);
		((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).setTime();
		((grannyRestart)gameController.GetComponent(typeof(grannyRestart))).startTimer = true;
		Object.Destroy(parent);
		Object.Destroy(top);
		Object.Destroy(head);
		Object.Destroy(leftArm);
		Object.Destroy(RightArm);
	}
}
