using UnityEngine;
using System.Collections;

/// <summary>
/// Title screen script
/// </summary>
public class EndScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 50;
		
		GUI.color = Color.red;
		GUI.backgroundColor = Color.white;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2) + 10,
			(2 * Screen.height / 4) - (buttonHeight / 2) - 60,
			buttonWidth,
			buttonHeight
			);

		Rect buttonRect2 = new Rect(
			Screen.width / 2 - (buttonWidth / 2) + 10,
			(2 * Screen.height /4) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Play Again"))
		{
			// On Click, load the first level.
			// "level one" is the name of the first scene we created.
			Application.LoadLevel("levelOne");
		}

		if(GUI.Button(buttonRect2,"Quit"))
		{
			// On Click, load the first level.
			// "level one" is the name of the first scene we created.
			Application.Quit();
		}
	}
}