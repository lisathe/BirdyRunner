using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			DeathController.instance.DisplayGameOverScreen ();
		}
	}
}
