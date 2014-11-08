using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatformObject : MonoBehaviour {
	List<GameObject> objectsOnPlatform;
	// Use this for initialization
	void Start () {
		objectsOnPlatform = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (objectsOnPlatform != null && objectsOnPlatform.Count > 0) {
			foreach(GameObject aGameObject in objectsOnPlatform){
				aGameObject.rigidbody2D.velocity += rigidbody2D.velocity;
			}
		}

	}

	void OnCollisionEnter(Collision col){
		objectsOnPlatform.Add (col.gameObject);
	}

	void OnCollisionExit(Collision col){
		objectsOnPlatform.Remove (col.gameObject);
	}
}
