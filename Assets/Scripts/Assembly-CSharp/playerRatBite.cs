using UnityEngine;
using UnityEngine.PostProcessing;

public class playerRatBite : MonoBehaviour
{
	public GameObject player;

	public bool playerIsBitten;

	public bool startFade;

	public float timer;

	public float fadeTimer;

	public PostProcessingProfile CC;

	private void Start()
	{
		CC.chromaticAberration.enabled = true;
		CC.vignette.enabled = true;
		ChromaticAberrationModel.Settings settings = CC.chromaticAberration.settings;
		VignetteModel.Settings settings2 = CC.vignette.settings;
		settings.intensity = 0f;
		settings2.intensity = 0f;
		CC.chromaticAberration.settings = settings;
		CC.vignette.settings = settings2;
	}

	private void Update()
	{
		if (playerIsBitten)
		{
			ChromaticAberrationModel.Settings settings = CC.chromaticAberration.settings;
			VignetteModel.Settings settings2 = CC.vignette.settings;
			settings.intensity = 1f;
			settings2.intensity = 0.6f;
			CC.chromaticAberration.settings = settings;
			CC.vignette.settings = settings2;
			startFade = false;
			timer += Time.deltaTime;
			if (timer >= 10f)
			{
				playerIsBitten = false;
				timer = 0f;
				startFade = true;
			}
		}
		if (startFade)
		{
			ChromaticAberrationModel.Settings settings3 = CC.chromaticAberration.settings;
			VignetteModel.Settings settings4 = CC.vignette.settings;
			settings3.intensity -= Time.deltaTime * 0.2f;
			settings4.intensity -= Time.deltaTime * 0.1f;
			CC.chromaticAberration.settings = settings3;
			CC.vignette.settings = settings4;
			if (settings4.intensity <= 0f)
			{
				startFade = false;
				settings4.intensity = 0f;
				settings3.intensity = 0f;
				CC.vignette.settings = settings4;
				CC.chromaticAberration.settings = settings3;
			}
		}
	}
}
