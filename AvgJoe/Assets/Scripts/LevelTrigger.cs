using UnityEngine;
using System.Collections;

public class LevelTrigger : MonoBehaviour { 
	void OnTriggerEnter2D(Collider2D other) { 
		Application.LoadLevel("levelTwo"); 
	} 
}