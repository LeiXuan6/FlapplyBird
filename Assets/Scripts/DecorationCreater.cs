using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationCreater : MonoBehaviour {
	public GameObject prefabs;
	private float startPosX = 12.73f;
	private static readonly float MARGIN = 5f; 
	private static readonly float Y_MAX = 2.18f;
	private static readonly float Y_MIN = -1.33f;
	private GameObject lastCreateDecoration;

	void Start () {
		
	}
	
	void Update () {
		if (lastCreateDecoration == null || startPosX-lastCreateDecoration.transform.position.x>=MARGIN ) {
			float startPosY = Random.Range (Y_MIN, Y_MAX);
			Vector2 position = new Vector2 (startPosX, startPosY);
			GameObject gameObj = Instantiate (prefabs,position , Quaternion.identity);
			lastCreateDecoration = gameObj;
		}
	}
}
 