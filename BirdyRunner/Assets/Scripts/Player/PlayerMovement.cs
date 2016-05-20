using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rb;
	public float jumpForce;

	// Use this for initialization
	void Awake () 
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Jump ();
	}

	private void Jump()
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
			rb.velocity = new Vector2 (rb.velocity.x, jumpForce * Time.deltaTime);
		}
			
	}

}
