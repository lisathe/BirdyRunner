using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce;

	Rigidbody2D rb;
	bool spacePressed;

	void Awake () 
	{
		rb = GetComponent<Rigidbody2D> ();
		spacePressed = false;
	}

	void FixedUpdate () 
	{
		if (spacePressed) 
		{
			Jump ();
		}
	}

	void Update()
	{
		spacePressed = Input.GetKeyDown (KeyCode.Space);
			
	}
	void Jump()
	{
		// negative jumpforce so the player jumps down
		rb.AddForce (new Vector2 (rb.velocity.x, -jumpForce));
	}
}
