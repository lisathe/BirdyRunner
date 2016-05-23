using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

	//Object Poolers
	public ObjectPooler pickupPool;
	public ObjectPooler obstaclePool;

	// Spawn range
	public Transform minSpawnPos, maxSpawnPos;
	Vector3 spawnPosition;

	//Timers
	float pickupTimer = 0;
	float obstacleTimer = 0;
	float pickUpSpawnInterval = 11f; 
	float obstacleSpawnInterval = 5f; 
	float estimatedPlaytime = 300f;

	//Mathf.Lerp
	float obstacleStartTime = 5f;
	float obstacleEndTime = 1f;
	float pickupStartTime = 11f;
	float pickUpEndTime = 3f;


	// Update is called once per frame
	void Update () 
	{
		if (obstacleTimer < obstacleSpawnInterval) 
		{
			obstacleTimer += Time.deltaTime;
		} 
		else 
		{
			obstacleTimer = 0;
			SpawnObject (obstaclePool);
			//Increase level difficulty by decreasing the spawn interval time
			obstacleSpawnInterval = Mathf.Lerp(obstacleStartTime, obstacleEndTime, Time.timeSinceLevelLoad / estimatedPlaytime);
		}

		if (pickupTimer < pickUpSpawnInterval) 
		{
			pickupTimer += Time.deltaTime;
		} 
		else 
		{
			pickupTimer = 0;
			SpawnObject (pickupPool);
			pickUpSpawnInterval = Mathf.Lerp(pickupStartTime, pickUpEndTime, Time.timeSinceLevelLoad / estimatedPlaytime);
		}
	}

	//Retrieves object from the pool and spawns it on a random y location
	void SpawnObject(ObjectPooler pool)
	{
		spawnPosition = new Vector3(minSpawnPos.position.x, Random.Range(minSpawnPos.position.y, maxSpawnPos.position.y),transform.position.z);
		GameObject newItem = pool.GetPooledObject ();
		newItem.transform.position = spawnPosition;
		newItem.transform.rotation = transform.rotation;
		newItem.SetActive (true);
	}
}