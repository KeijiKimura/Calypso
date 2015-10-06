using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RoboChirp : MonoBehaviour {
	public AudioClip chirpAudio;
	public GameObject heart;
	AudioSource audio;
	
	void Start() {
		audio = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("GoodPlant")) {
			audio.PlayOneShot (chirpAudio, 0.7F);
			heart.SetActive (true);

		}
	}

	void OnTriggerExit(Collider other) {
			if(other.CompareTag ("GoodPlant")) {
				heart.SetActive(false);

			}



		}
		

	}
