using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashScreenStart : MonoBehaviour
{
	public AudioClip sound;

	public AudioClip sound2;

	public GameObject text;

	private void Start()
	{
		Cursor.visible = false;
		Screen.lockCursor = true;
		StartCoroutine(readyToStart());
	}

	public virtual IEnumerator readyToStart()
	{
		yield return new WaitForSeconds(0.5f);
		text.SetActive(value: true);
		yield return new WaitForSeconds(15f);
		SceneManager.LoadScene("Menu");
	}
}
