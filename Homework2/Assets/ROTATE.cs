using UnityEngine;
using System.Collections;

public class ROTATE : MonoBehaviour {
	
	public Transform center;
	
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.up * 2f);
		
		//transform.position = new Vector3 (transform.position.x, Mathf.Lerp (12.5f, 11.5f, 2f), transform.position.z);
	}
}