using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using Kino;

public class PollenKill : MonoBehaviour {
	public Transform checkPoint;
	public GameObject PlayerObject;
	public AudioClip HurtNoise;
	public GameObject Surprise;
	public float Health = 0.01f;
	AudioSource audio;
	AnalogGlitch intensify;
	
	void Start() {
		audio = GetComponent<AudioSource>();
		intensify = GetComponent <AnalogGlitch> (); 
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("Pollen")) {
			PlayerObject.gameObject.GetComponent <AnalogGlitch> ().enabled = true;
			audio.PlayOneShot (HurtNoise, 0.7F);
			Health  ++;
			Surprise.SetActive(true);
			//			Debug.Log ("GLITCH WORKS!");
		}
	}
	
	
	void Update() {
		
		if (Health >= 50f){
			Debug.Log ("Dead!");
			PlayerObject.gameObject.GetComponent <DigitalGlitch> ().enabled = true;
			//Death ();
			
		}
		
		
	}
	
	
	void OnTriggerExit (Collider other) {
		if (other.CompareTag ("Pollen")) {
			CancelInvoke ("TakeDamage");
			Surprise.SetActive (false);	
			PlayerObject.gameObject.GetComponent <AnalogGlitch> ().enabled = false;
		}
	}
	
	void OnTriggerStay (Collider other) {
		if (other.CompareTag ("Pollen")) {
			
			InvokeRepeating ("TakeDamage", 1, 1);
		}
	}
	
	void TakeDamage(){
		Health ++;
	}
	
	public void Death() {
		StartCoroutine (Dead ());
		
	}
	
	IEnumerator Dead()
	{
		yield return new WaitForSeconds (3);
		Application.LoadLevel ("Test2");
		
		
	}
}