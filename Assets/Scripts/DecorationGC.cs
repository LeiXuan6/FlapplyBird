using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationGC : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name.Contains ("Decoration(Clone)")) {
			DestroyObject (other.gameObject);
		}
	}
}
