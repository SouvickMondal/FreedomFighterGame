using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medi_Collected : MonoBehaviour {
	public GameObject obj_medipack;
	public GameObject h1;
	public GameObject h2;
	public GameObject h3;
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
			
			h1.SetActive(true);
			obj_medipack.SetActive (false);
			Debug.Log ("Medipack Collected");
		}
	} 
}
