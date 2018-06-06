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

	public int curHealth;
	public int maxHealth = 100;
	public GameObject GameOver;

	SpriteRenderer _renderer;



	void Start(){

		rb = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator> ();
		_renderer = GetComponent<SpriteRenderer> ();

		curHealth = maxHealth;
		GameOver.SetActive (false);



	}

	void Update(){

		grounded = Physics2D.Linecast (transform.position, groundCheck.position, 1 << LayerMask.NameToLayer ("Ground"));

		anim.SetBool ("grounded" , grounded);
		anim.SetFloat ("airtime", rb.velocity.y);
		anim.SetFloat ("speed", Mathf.Abs (Input.GetAxis ("Horizontal")));

		if (Input.GetAxis ("Horizontal") < -0.1f) {
			_renderer.flipX = true;
		}

		if (Input.GetAxis ("Horizontal") > 0.1f) {
			_renderer.flipX = false;
		}

		if (Input.GetButtonDown ("Jump") && grounded) {
			rb.AddForce (Vector2.up * jumpPwer, ForceMode2D.Impulse);
			anim.SetTrigger ("jumping");
		}


		if (curHealth > maxHealth) {

			curHealth = maxHealth;
		}

		if (curHealth <= 0) {
			Die ();
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

		if (h == 0) {
			rb.velocity = new Vector2 (0, rb.velocity.y);
		}
			
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "mushroom") {
			rb.AddForce (Vector2.up * jumpPwer * 1.5f, ForceMode2D.Impulse);
		}
		if (other.gameObject.tag == "water") {
			Die ();
		}

	}


	void OnTriggerEnter2D(Collider2D other){

		//to add if collision from the Top Part of the Wasp. If player touches wasp from sides, it will remove 1 heart.
		//Destroy (other.gameObject);

		if (other.tag == "MovingPlatform") {
			transform.parent = other.gameObject.transform;
		}

	}

	void OnTriggerExit2D(Collider2D other){

		//to add if collision from the Top Part of the Wasp. If player touches wasp from sides, it will remove 1 heart.
		//Destroy (other.gameObject);

		if (other.tag == "MovingPlatform") {
			transform.parent = null;
		}
	}

	void Die(){
		Time.timeScale = 0;
		GameOver.SetActive (true);
	}


	public void Damage(int dmg){

		curHealth -= dmg;
		anim.SetTrigger ("damage");

	}

	public void Knockback(){
		float direction = _renderer.flipX ? 1 : -1;
		Vector2 force = new Vector2 (direction * 150f, 7.5f);
		rb.AddForce (force, ForceMode2D.Impulse);
	}
}
