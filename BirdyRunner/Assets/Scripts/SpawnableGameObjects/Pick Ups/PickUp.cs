using UnityEngine;
using System.Collections;

public class PickUp : SpawnableGameObject {
		

	public override void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			ScoreSystem.instance.AddScore ();
		}
		base.OnTriggerEnter2D (col);
	}
}
