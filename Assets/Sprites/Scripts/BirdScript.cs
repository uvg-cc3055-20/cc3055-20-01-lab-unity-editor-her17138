using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
	public float JumpForce = 80f;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) {
			rb.velocity = Vector2.zero;
			rb.AddForce (Vector2.up * JumpForce);
		}

	}
}
