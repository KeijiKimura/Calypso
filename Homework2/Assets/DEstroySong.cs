using UnityEngine;
using System.Collections;

public class DEstroySong : MonoBehaviour {
	
	static public bool DestroySong;

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			DontDestroy.DestroySong=true;
			Debug.Log ("Work");
		}
		
	}
}