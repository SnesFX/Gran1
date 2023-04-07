using UnityEngine;

public class ratBite : MonoBehaviour
{
	public GameObject playerAnim;

	public GameObject noiseobject;

	public Transform noiseDropPoint;

	public GameObject gameController;

	public GameObject ratController;

	public AudioClip ratNoise;

	public AudioClip ratNoise2;

	public virtual void Start()
	{
	}

	public virtual void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			playerAnim.gameObject.GetComponent<Animation>().Play("playerHurt");
			((playerInBeartrap)gameController.GetComponent(typeof(playerInBeartrap))).playerStuck();
			((playerRatBite)gameController.GetComponent(typeof(playerRatBite))).playerIsBitten = true;
			((playerRatBite)gameController.GetComponent(typeof(playerRatBite))).timer = 0f;
			Object.Instantiate(noiseobject, noiseDropPoint.position, noiseDropPoint.rotation);
			((ratController)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			GetComponent<AudioSource>().PlayOneShot(ratNoise);
		}
		else if (other.gameObject.tag == "arrow")
		{
			((ratController)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			GetComponent<AudioSource>().PlayOneShot(ratNoise2);
		}
		else if (other.gameObject.tag == "granny")
		{
			((ratController)ratController.GetComponent(typeof(ratController))).Waittimer = 100f;
			GetComponent<AudioSource>().PlayOneShot(ratNoise2);
		}
	}
}
