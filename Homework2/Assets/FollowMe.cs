using UnityEngine;
using System.Collections;

public class FollowMe : MonoBehaviour {
	
	public GameObject player;
	public float followRange;
	public float speed = 5;  
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.LookAt (player.transform.position);
		
		if(Vector3.Distance(transform.position, player.transform.position) >= followRange) {
			transform.position += (transform.forward * speed);
			
			
			
		}
		
		
	}
}