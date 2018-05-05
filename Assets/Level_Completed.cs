using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Completed : MonoBehaviour {
	public GameObject obj_levelcleared;
	public GameObject obj_tank;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player" ) 		// Other Object Name
		{
		//	obj_levelcleared.SetActive (true);
			Application.LoadLevel("Game 1");
			//obj_tank.SetActive (false);
			Debug.Log ("Level Cleared");
		}
	} 
}
