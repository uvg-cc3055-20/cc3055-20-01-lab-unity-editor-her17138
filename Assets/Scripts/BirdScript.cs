using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {
	public float JumpForce = 150f;
	Rigidbody2D rb;
	public float forwardSpeed = 0.5f;
	public GameObject cam;
	public bool dead = false;

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dead == false) {
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = Vector2.one;
				rb.AddForce (Vector2.up * JumpForce);
			}
			rb.transform.Translate (new Vector3 (1, 0, 0) * forwardSpeed * Time.deltaTime);
			cam.transform.Translate (new Vector3 (1, 0, 0) * (forwardSpeed+ 0.8f) * Time.deltaTime);
			if (rb.transform.position.x > 50.36294) {
				dead = true;
			}
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		dead = true;
	}


}
