using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

	public Text scoreText;

	int totalPoints;
	int points;
	static ScoreSystem _instance;

	/* 
	 * Using Singleton: 
	 * Creates a static get property, which returns the current ScoreSystem.
	 * The method can be called by its class definition and can be used to call this script from other scripts.
	 * PS: DO NOT CREATE A NEW INSTANCE of this class! Use Scoresystem.instance.Method();
	*/

	public static ScoreSystem instance
	{
		get
		{
			if (_instance == null)
				_instance = GameObject.FindWithTag ("ScoreController").GetComponent<ScoreSystem>();
			return _instance;
		}
	}
	void Awake () 
	{
		totalPoints = 0;
		points = 20;
	}
		

	public void AddScore()
	{
		totalPoints += points;
		SetScoreText (scoreText);
	}

	public void SetScoreText(Text scoreText)
	{
		scoreText.text = "Score: " + totalPoints.ToString();
	}
		
	public void ResetScore()
	{
		totalPoints = 0;
	}
}
