using UnityEngine;
using System.Collections;

public class Obstacle : SpawnableGameObject {

	public override void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			DeathController.instance.PlayerDeath ();
			DeathController.instance.DisplayGameOverScreen ();
		}
		base.OnTriggerEnter2D (col);
	}
}
