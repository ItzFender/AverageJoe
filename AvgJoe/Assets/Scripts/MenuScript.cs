using UnityEngine;
using System.Collections;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 150;
		const int buttonHeight = 50;

		//GUI.color = Color.red;
		GUI.backgroundColor = Color.white;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2) + 10,
			(2 * Screen.height / 8) - (buttonHeight / 2) - 60,
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"New Game"))
		{
			// On Click, load the first level.
			// "level one" is the name of the first scene we created.
			Application.LoadLevel("level one");
		}
	}
}