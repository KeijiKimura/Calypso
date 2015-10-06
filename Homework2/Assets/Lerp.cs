using UnityEngine;
using System.Collections;

public class Lerp : MonoBehaviour
{
	
	bool isGoingForwards = true;
	
	
	public Transform from;
	public Transform to;
	public float percentage = 0f;
	
	
	// Update is called once per frame
	void Update () {
		//if going backwards
		if (isGoingForwards == false) {
			percentage -= Time.deltaTime / 6f;
		}
		if (isGoingForwards == true) {
			percentage += Time.deltaTime / 6f;
		}
		
		if (percentage >1) {
			isGoingForwards = false;
		}
		//if going forwards
		
		if (percentage < 0) {
			isGoingForwards = true;
		}
		transform.position= Vector3.Lerp (from.position, to.position, percentage);
		/*renderer.material.color = Color.Lerp (Color.red, Color.blue, percentage);

        transform.rotation = Quaternion.Slerp (Quaternion.identity, new Quaternion (1, 0, 1, 0), percentage); */
		
		
	}
}