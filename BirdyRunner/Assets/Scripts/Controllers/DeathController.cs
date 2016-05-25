using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour {

	static DeathController _instance;

	public Canvas gameOverScreen;
	public Canvas scoreScreen;
	public Text endScore;

	GameObject player;
	ParticleSystemController explosion;

	void Awake()
	{
		scoreScreen = scoreScreen.GetComponent<Canvas> ();
		gameOverScreen = gameOverScreen.GetComponent<Canvas> ();
		gameOverScreen.enabled = false;
		player = GameObject.FindWithTag ("Player");
		explosion = player.GetComponent<ParticleSystemController> ();
	}

	public static DeathController instance
	{
		get
		{
			if (_instance == null)
				_instance = GameObject.FindWithTag ("DeathController").GetComponent<DeathController>();
			return _instance;
		}
	}

	public void PlayerDeath()
	{
		explosion.spawnParticleSystem (player);
		player.SetActive (false);

	}
	public void DisplayGameOverScreen()
	{
		scoreScreen.enabled = false;
		gameOverScreen.enabled = true;
		ScoreSystem.instance.SetScoreText (endScore);
	}

	public void Retry()
	{
		ScoreSystem.instance.ResetScore ();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}
