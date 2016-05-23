using UnityEngine;
using System.Collections;

public class Timer :MonoBehaviour {


	public void ObjectTimer(float _timer, float spawnInterval)
	{

		if (_timer < spawnInterval) 
		{
			_timer += Time.deltaTime;
		} 
		else 
		{
			_timer = 0;
			//SpawnObject (obstaclePool);
		}
	}
}
