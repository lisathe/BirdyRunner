using UnityEngine;
using System.Collections;

public class SpawnableGameObject : MonoBehaviour {

	protected Vector2 speed;
	protected Vector2 direction;
	protected Rigidbody2D rb;
	protected GameObject deletePoint;
	protected AudioClip collisionSound;

	public virtual void Awake () 
	{
		rb = GetComponent<Rigidbody2D> ();
		direction = new Vector2 (-1, 0); // Moving to the left
		speed = new Vector2(1,0);
		deletePoint = GameObject.Find("gameobjectDeletePoint");
	}

	protected void Update()
	{
		DisableGameObject ();
	}
	protected void FixedUpdate () 
	{
		rb.velocity = new Vector2 (speed.x * direction.x, rb.velocity.y);
	}

	protected void DisableGameObject()
	{
		if (transform.position.x < deletePoint.transform.position.x)
		{
			gameObject.SetActive (false);
		}
	}

	public virtual void OnTriggerEnter2D ( Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			gameObject.SetActive (false);
			AudioSource.PlayClipAtPoint (collisionSound, transform.position);
		}
	}
}
