using System.Collections;
using UnityEngine;

public class freezeTrap : MonoBehaviour
{
	public Transform spawnObject;

	public GameObject Granny;

	public GameObject gameController;

	public bool trapActivated;

	public bool GrannyFreeze;

	public GameObject steam;

	public Texture red;

	public Texture green;

	public Renderer rend;

	public AudioClip freezeSound;

	private void Start()
	{
		Granny = GameObject.Find("GrannyParent");
		gameController = GameObject.Find("GameController");
		rend = GetComponent<Renderer>();
		rend.material.mainTexture = red;
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "golv" || other.gameObject.tag == "grus")
		{
			trapActivated = true;
			rend.material.mainTexture = green;
		}
		if (((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).playerGetCaught || !trapActivated)
		{
			return;
		}
		if (other.gameObject.tag == "granny")
		{
			base.gameObject.tag = "Untagged";
			trapActivated = false;
			((EnemyAIGranny)Granny.GetComponent(typeof(EnemyAIGranny))).freeze = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			GetComponent<AudioSource>().PlayOneShot(freezeSound);
			StartCoroutine(timer());
		}
		else if (other.gameObject.tag == "Player")
		{
			base.gameObject.tag = "Untagged";
			trapActivated = false;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			GetComponent<AudioSource>().PlayOneShot(freezeSound);
			StartCoroutine(timer());
			((PlayerFreeze)gameController.GetComponent(typeof(PlayerFreeze))).playerFreezeStuck();
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
		}
		else if (other.gameObject.tag == "Spider")
		{
			base.gameObject.tag = "Untagged";
			trapActivated = false;
			((Rigidbody)base.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
			steam.GetComponent<ParticleSystem>().enableEmission = true;
			rend.material.mainTexture = red;
			GetComponent<AudioSource>().PlayOneShot(freezeSound);
			StartCoroutine(timer());
			if ((bool)GameObject.Find("TempNavObjects(Clone)"))
			{
				GameObject.Find("TempNavObjects(Clone)").transform.name = "TempNavObjects(Clone)Old";
				Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
			else if ((bool)GameObject.Find("TempNavObjects(Clone)Old"))
			{
				Object.Destroy(GameObject.Find("TempNavObjects(Clone)Old"));
			}
			else
			{
				Object.Instantiate(spawnObject, base.transform.position, base.transform.rotation);
			}
		}
	}

	public virtual IEnumerator timer()
	{
		yield return new WaitForSeconds(3.5f);
		steam.GetComponent<ParticleSystem>().enableEmission = false;
		base.gameObject.tag = "freezetrap";
	}
}
