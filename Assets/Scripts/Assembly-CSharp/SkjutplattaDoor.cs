using System.Collections;
using UnityEngine;

public class SkjutplattaDoor : MonoBehaviour
{
	public bool doorUnlocked;

	public bool doorUnlockedArrow;

	public GameObject steelDoor;

	public GameObject lockDel1;

	public GameObject lockDel2;

	public AudioClip unlockLjud;

	private void Start()
	{
	}

	private void Update()
	{
		if (doorUnlocked)
		{
			doorUnlocked = false;
			steelDoor.gameObject.tag = "innerdoorClosed";
			lockDel1.gameObject.GetComponent<Animation>().Play("skjutPlatta");
			lockDel2.gameObject.GetComponent<Animation>().Play("skjutPlattaDel1");
			GetComponent<AudioSource>().PlayOneShot(unlockLjud);
			StartCoroutine(ljudlength());
		}
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "arrow" && !doorUnlockedArrow)
		{
			doorUnlockedArrow = true;
			steelDoor.gameObject.tag = "innerdoorClosed";
			lockDel1.gameObject.GetComponent<Animation>().Play("skjutPlatta");
			lockDel2.gameObject.GetComponent<Animation>().Play("skjutPlattaDel1");
			GetComponent<AudioSource>().PlayOneShot(unlockLjud);
			StartCoroutine(ljudlength());
		}
	}

	public virtual IEnumerator ljudlength()
	{
		yield return new WaitForSeconds(1f);
		Object.Destroy(base.gameObject);
	}
}
