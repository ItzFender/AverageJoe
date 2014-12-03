using UnityEngine;
using System.Collections;

public class Level2Trigger : MonoBehaviour { 
	void OnTriggerEnter2D(Collider2D other) { 
		Application.LoadLevel("levelTwo"); 
	} 
}