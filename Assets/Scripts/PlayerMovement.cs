using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 3;
	public float speed = 50f;
	public float jumpPwer = 50f;

	public bool grounded;

	private Rigidbody2D rb;
	private Animator anim;
	public Transform groundCheck;

	void Start(){

		rb = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator> ();

	}

	void Update(){

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

		anim.SetBool ("grounded" , grounded);
		anim.SetFloat ("airtime", rb.velocity.y);
		anim.SetFloat ("speed", Mathf.Abs (Input.GetAxis ("Horizontal")));

		if (Input.GetAxis ("Horizontal") < -0.1f) {
			transform.localScale = new Vector3 (-1, 1, 1);
		}

		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector3 (1, 1, 1);
		}

		if (Input.GetButtonDown ("Jump") && grounded) {
			rb.AddForce (Vector2.up * jumpPwer, ForceMode2D.Impulse);
			anim.SetTrigger ("jumping");
		}
	}

	void FixedUpdate(){

		float h = Input.GetAxis ("Horizontal");
		rb.AddForce ((Vector2.right * speed) * h);

		if (rb.velocity.x > maxSpeed) {
			rb.velocity = new Vector2 (maxSpeed, rb.velocity.y);

		}

		if (rb.velocity.x < -maxSpeed) {
			rb.velocity = new Vector2 (-maxSpeed, rb.velocity.y);
		}
			
	}


}
