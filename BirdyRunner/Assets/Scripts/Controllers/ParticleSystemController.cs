using UnityEngine;
using System.Collections;

public class ParticleSystemController : MonoBehaviour {

	//Prefab particle system
	public GameObject particle;

	public void spawnParticleSystem(GameObject placeToBeSpawned)
	{
		Instantiate (particle, placeToBeSpawned.transform.position, placeToBeSpawned.transform.rotation);
		//Destroy (gameObject, 1f);
		Debug.Log("ps spawned");
	}
}
