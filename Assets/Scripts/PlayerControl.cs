using System.Collections;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	private float speed = 10f;
	private float jump = 10f;
	private float gravity = 30f;
	private float rotate = 60f;
	private Vector3 moveDir = Vector3.zero;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, Input.GetAxis("Horizontal") * 60f * Time.deltaTime);
		CharacterController controller = gameObject.GetComponent<CharacterController> ();

		if (controller.isGrounded) {
			moveDir = new Vector3 (0, 0, Input.GetAxis("Vertical"));

			moveDir = transform.TransformDirection (moveDir);

			moveDir *= speed;

			if (Input.GetButtonDown("Jump")) {
					moveDir.y = jump;
			}

		}

		
		moveDir.y -= gravity * Time.deltaTime;

				controller.Move (moveDir * Time.deltaTime);

	}
}
