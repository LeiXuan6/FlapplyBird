using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {
	private Rigidbody2D rb2d;
	public float scrollMoveSpeed = -1f;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (scrollMoveSpeed, 0);
	}
	
	void Update () {
		if (GameController.getInstance ().isGameOver ()) {
			rb2d.velocity = Vector2.zero;
		}
	}
}
