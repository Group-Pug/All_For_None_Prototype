using UnityEngine;
using System.Collections;

public class SplashScreenSoundHandler : MonoBehaviour {
	[SerializeField] private AudioClip cinematicImpact;
	[SerializeField] private AudioClip dogBark;

	void Start() {
		PlayCinematicImpact();
	}

	void PlayCinematicImpact () {
		Camera.main.GetComponent<AudioSource>().clip = cinematicImpact;
		Camera.main.GetComponent<AudioSource>().Play();
	}

	void PlayDogBark() {
		Camera.main.GetComponent<AudioSource>().PlayOneShot(dogBark);
	}

}
