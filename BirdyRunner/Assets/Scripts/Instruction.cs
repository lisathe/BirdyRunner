using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Instruction : MonoBehaviour {

	public Canvas instructionScreen;

	void Awake()
	{
		instructionScreen = instructionScreen.GetComponent<Canvas> ();
	}
	void Update()
	{
		//If player presses space, remove instruction from screen
		if (Input.GetKeyDown (KeyCode.Space))
		{
			instructionScreen.enabled = false;
		}
	}
}
