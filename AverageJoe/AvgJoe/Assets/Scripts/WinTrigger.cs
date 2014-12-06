using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour { 
	void OnTriggerEnter2D(Collider2D other) { 
		Application.LoadLevel("Game Win"); 
	} 
}
