using UnityEngine;
using System.Collections;

public class KillZone : MonoBehaviour {

	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			Application.LoadLevel ("Lighttest");
		}

	}
}