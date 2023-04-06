using System.Collections;
using UnityEngine;

public class plaskLjudTrigger : MonoBehaviour
{
	public bool ljudSpelats;

	public AudioClip plaskljud;

	private void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && !ljudSpelats)
		{
			ljudSpelats = true;
			GetComponent<AudioSource>().PlayOneShot(plaskljud);
			StartCoroutine(ljudlength());
		}
	}

	public virtual IEnumerator ljudlength()
	{
		yield return new WaitForSeconds(1f);
		ljudSpelats = false;
		base.gameObject.SetActive(value: false);
	}
}
