using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Collider : MonoBehaviour {
	public GameObject obj;
	public GameObject h1;
	public GameObject obj_levelcleared;

	public GameObject h2;
	public GameObject h3;
	static int h=3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Player" && gameObject.tag == "t1") { 		// Other Object Name
			Destroy (obj);
			if (h == 3) {
				
				h -= 1;
				h1.SetActive (false);
				Debug.Log ("h="+h);
			} else if (h == 2) {
				h -= 1;
				h2.SetActive (false);
				Debug.Log ("h="+h);
			} else if (h == 1) {
				h -= 1;
				h3.SetActive (false);
				Debug.Log ("h="+h);
				obj_levelcleared.SetActive (true);
			}
		} else if (coll.gameObject.name == "Player" && gameObject.tag == "t2") {
			Destroy (obj);

			if (h == 1) {
				h += 1;
				Debug.Log ("h="+h);
				h2.SetActive (true);
			} else if (h == 2) {
				h += 1;
				Debug.Log ("h="+h);
				h1.SetActive (true);
			}
		}
	} 

}
