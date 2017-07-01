using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatedBackGround : MonoBehaviour {
	private BoxCollider2D box2d;
	private float backgroundWidth ;

	void Start () {
		box2d = GetComponent<BoxCollider2D> ();
		backgroundWidth = box2d.size.x;
	}
	
	void Update () {
		if (transform.position.x < -backgroundWidth) {
			Repeated ();
		}
	}

	void Repeated(){
		Vector3 newPosition = new Vector3 (backgroundWidth * 2, 0, 0);
		transform.position += newPosition;
	}
}
