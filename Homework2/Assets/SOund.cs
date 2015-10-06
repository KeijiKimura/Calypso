using UnityEngine;
using System.Collections;

public class SOund : MonoBehaviour {
	


	public AudioClip Song1;
	 AudioSource Level1Music;
	

	// Use this for initialization
	void Start () {
		Level1Music = GetComponent<AudioSource> ();

		
	}
	
	// Update is called once per frame

	public void FadeMusic()
	{
		StartCoroutine (FadeMusic1 ());
	
	}
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			FadeMusic ();
		
		} 
		
	}

	IEnumerator FadeMusic1()
	{
		while(Level1Music.volume > .025F)
		{
		Level1Music.volume = Mathf.Lerp (Level1Music.volume, 0F, Time.deltaTime);
			yield return 0;
	}
	Level1Music.volume = 0.00f;
}
}
