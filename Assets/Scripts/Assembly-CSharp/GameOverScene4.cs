using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScene4 : MonoBehaviour
{
	public GameObject GameController;

	public GameObject Granny;

	public GameObject vindSound;

	public AudioClip smack;

	public AudioClip GrannySound;

	public AudioClip playerLand;

	public Image blackScreenTexture;

	public GameObject gameOverText;

	public Image gameOverTexture;

	public GameObject Beartrap;

	public GameObject BeartrapNM;

	public virtual IEnumerator Start()
	{
		if (PlayerPrefs.GetInt("NightMareOnOff") == 1)
		{
			BeartrapNM.SetActive(value: true);
		}
		else
		{
			Beartrap.SetActive(value: true);
		}
		Granny.GetComponent<Animation>().CrossFade("GrannyPush");
		yield return new WaitForSeconds(15f);
		AudioSource.PlayClipAtPoint(GrannySound, base.transform.position);
		yield return new WaitForSeconds(10.5f);
		AudioSource.PlayClipAtPoint(smack, base.transform.position);
		yield return new WaitForSeconds(2.5f);
		blackScreenTexture.CrossFadeAlpha(1f, 0.02f, ignoreTimeScale: false);
		gameOverText.SetActive(value: true);
		vindSound.SetActive(value: false);
		AudioSource.PlayClipAtPoint(playerLand, base.transform.position);
		yield return new WaitForSeconds(4f);
		gameOverTexture.CrossFadeAlpha(0f, 2.2f, ignoreTimeScale: false);
		yield return new WaitForSeconds(3f);
		((FetchAds)GameController.GetComponent(typeof(FetchAds))).toMainMenu();
	}
}
