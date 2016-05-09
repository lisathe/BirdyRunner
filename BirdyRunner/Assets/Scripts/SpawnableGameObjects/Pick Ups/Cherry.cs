using UnityEngine;
using System.Collections;

public class Cherry : MonoBehaviour {
		 
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player"))
		{
			ScoreSystem.instance.AddScore ();
			gameObject.SetActive (false);
		}
	}
}
