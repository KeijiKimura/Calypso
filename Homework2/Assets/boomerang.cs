using UnityEngine;
using System.Collections;

public class boomerang : MonoBehaviour {
	
	public GameObject player;
	
	
	void Update () {
		if (Input.GetMouseButtonDown (2)) {
			StartCoroutine(Throw(2.0f, .5f, player.transform.forward, 2f));
			Debug.Log ("THROW");
		}
		
		
		
	}
	
	IEnumerator Throw(float dist, float width, Vector3 direction, float time) {
		Vector3 pos = transform.position;
		float height = transform.position.y - 2f;
		Quaternion q = Quaternion.FromToRotation (Vector3.forward, direction);
		float timer = 0.0f;
		GetComponent<Rigidbody>().AddTorque (1.0f, 100.0f, 10.0f);
		while (timer < time) {
			float t = Mathf.PI * 2.0f * timer / time - Mathf.PI/2.0f;
			float x = width * Mathf.Cos(t);
			float z = dist * Mathf.Sin (t);
			Vector3 v = new Vector3(x,height,z+dist);
			GetComponent<Rigidbody>().MovePosition(pos + (q * v));
			timer += Time.deltaTime;
			yield return null;
		}
		
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().rotation = Quaternion.identity;
		GetComponent<Rigidbody>().MovePosition (pos);
	}
}