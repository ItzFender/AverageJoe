using UnityEngine;
using System.Collections;

public class Level3Trigger : MonoBehaviour { 
	void OnTriggerEnter2D(Collider2D other) { 
		Application.LoadLevel("levelThree"); 
	} 
}
