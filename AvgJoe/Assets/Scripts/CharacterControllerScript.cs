using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = true;

	Animator anim;

	//jumping variables
	bool grounded = false;
	public Transform groundCheck;
	float groundRadious = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	bool doubleJump = false;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadious, whatIsGround);
		anim.SetBool ("Ground", grounded);

		if (grounded)
						doubleJump = false;

		anim.SetFloat("vSpeed", rigidbody2D.velocity.y);

		float move = Input.GetAxis ("Horizontal");

		anim.SetFloat("Speed", Mathf.Abs(move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight)
						flip ();
		if (move < 0 && facingRight)
						flip ();
	}

	void Update(){
		if ((grounded || !doubleJump) && Input.GetKeyDown ("space")) {
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));

			if(!doubleJump && !grounded)
				doubleJump = true;

		}

		if(!grounded && Input.GetKeyDown("s")){
			rigidbody2D.AddForce(new Vector2(0, -jumpForce));
		}
	}

	void flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
