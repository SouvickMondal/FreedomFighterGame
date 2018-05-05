using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coli : MonoBehaviour {
	public GameObject obj;
	public GameObject h1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player" ) 		// Other Object Name
		{
			Destroy (obj);
			h1.SetActive(false);
			Debug.Log ("hit");
		}
	} 
}
