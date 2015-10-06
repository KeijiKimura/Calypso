using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	static public bool DestroySong;
	public GameObject Song;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	void Update() {
		if (DestroySong) {
			Song.SetActive (false);
		}

	}
}