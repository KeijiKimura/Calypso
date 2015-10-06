using UnityEngine;
using System.Collections;

public class TouchFlower : MonoBehaviour {
	public GameObject bloomObject;
	public GameObject sampleObject;
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			bloomObject.SetActive (true);
			sampleObject.SetActive (true);
			Debug.Log ("Touch working");
		}
	
	}
}