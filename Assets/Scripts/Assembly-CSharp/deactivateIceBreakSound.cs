using UnityEngine;

public class deactivateIceBreakSound : MonoBehaviour
{
	public AudioClip iceBreak;

	public virtual void playIceBreak()
	{
		GetComponent<AudioSource>().PlayOneShot(iceBreak);
	}
}
