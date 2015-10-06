using UnityEngine;
using System.Collections;

public class CaveIn : MonoBehaviour {


	public static bool beginCaveIn;
	public Rigidbody Rock;

	public GameObject bigRock;
	// Use this for initialization
	void Start () {
		Rock = bigRock.GetComponentInChildren<Rigidbody> ();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			Rock.isKinematic = false;
			Rock.detectCollisions = true;
		} 
		
	}
}
