using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	Rigidbody2D PlayerRigidbody;
	public float MoveSpeed;
	public bool grounded;
	//INSCORE In;
	public Transform groundCheck;
	public AudioClip CoincollectSound;
	public AudioClip aud;
	private Animator anim;
	// Use this for initialization
	void Start () {
		PlayerRigidbody=GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator> ();
	//	In = GameObject.Find ("NIL").GetComponent<INSCORE> ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded =Physics2D.Linecast(transform.position,groundCheck.position,1<<LayerMask.NameToLayer("Ground"));
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			if(transform.eulerAngles.y!=180)
				transform.eulerAngles=new Vector3(0,180,0);
			anim.Play ("walk");
			PlayerRigidbody.velocity=new Vector2(-MoveSpeed,PlayerRigidbody.velocity.y);
		}
		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			anim.Play ("idle");
		}

		if(Input.GetKey(KeyCode.RightArrow))
		{
			if(transform.eulerAngles.y!=0)
				transform.eulerAngles=new Vector3(0,0,0);
			anim.Play ("walk");
			PlayerRigidbody.velocity=new Vector2(MoveSpeed,PlayerRigidbody.velocity.y);
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			anim.Play ("idle");
		}

		if (Input.GetKey(KeyCode.Space)&&grounded) {
			anim.Play ("idle");
			PlayerRigidbody.AddForce (new Vector3(0,250f,0));
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			anim.Play ("idle");
		}
	}

	public void OnCollisionEnter2D(Collision2D collision){
		
		if (collision.gameObject.tag == "t1") {
		//	In.SendMessage("Inscore");
	//		Debug.Log ("yup");
			GetComponent<AudioSource> ().PlayOneShot (CoincollectSound, 50);
	}
		if (collision.gameObject.tag == "t2") {
			GetComponent<AudioSource> ().PlayOneShot (aud, 50);
		}
	}
}
