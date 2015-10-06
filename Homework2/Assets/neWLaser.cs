using UnityEngine;
using System.Collections;

public class neWLaser : MonoBehaviour
{
	LineRenderer line;
	public AudioClip LaserSound;
	AudioSource audio;
	public int PushForce=-5;
	// Use this for initialization
	void Start ()
	{
		audio = GetComponent<AudioSource> ();
		line = gameObject.GetComponent<LineRenderer>();
		line.enabled = false;
		gameObject.GetComponent<Light> ().enabled = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			audio.PlayOneShot (LaserSound,0.7F);
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");
		}
		
	}
	
	IEnumerator FireLaser()
	{
		line.enabled = true;
		gameObject.GetComponent<Light> ().enabled = true;
		
		while (Input.GetButton ("Fire1"))
		{
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			line.SetPosition (0, ray.origin);
			if (Physics.Raycast (ray, out hit, 100))
			{
				line.SetPosition (1, hit.point);
				if (hit.rigidbody)
				{
					//Debug.Log ("WOrking");
					hit.rigidbody.AddForceAtPosition(transform.forward * PushForce,hit.point);
				}
			} else
				line.SetPosition (1, ray.GetPoint (100));
			yield return null;
			
		}
		line.enabled = false;
		gameObject.GetComponent<Light> ().enabled = false;
	}
}