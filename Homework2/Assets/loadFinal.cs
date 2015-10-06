using UnityEngine;
using System.Collections;

public class loadFinal : MonoBehaviour {
	
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			Application.LoadLevel ("Test");
			Debug.Log ("Work");
		}
		
	}
}