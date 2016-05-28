using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float jumpForce;

	Rigidbody2D rb;

	void Awake () 
	{
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump();
		}
			
	}
	void Jump()
	{
		rb.velocity = Vector2.zero;
		// negative jumpforce so the player jumps down
		rb.AddForce (new Vector2 (rb.velocity.x, -jumpForce));
	}
}
