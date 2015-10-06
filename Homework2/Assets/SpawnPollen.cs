using UnityEngine;
using System.Collections;

public class SpawnPollen : MonoBehaviour {
	public GameObject Pollen;
	public GameObject CaveInEnable;
	public GameObject PollenSong;

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			Pollen.SetActive(true);
			CaveInEnable.SetActive(true);
			PollenSong.SetActive(true);
		}
		if (other.CompareTag("WhitePlayer")){

		}
	}
}