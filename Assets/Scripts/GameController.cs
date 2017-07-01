using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	private static GameController instance;
	private bool gameOver = false;
	public GameObject gameOverText;
	public Text scoreText;
	private int score = 0;

	private GameController (){
	}

	public static GameController getInstance(){
		return instance;
	}

	public bool isGameOver(){
		return gameOver;
	}

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			DestroyObject (gameObject);
		}
	}

	public void BirdDead(){
		gameOver = true;
		gameOverText.SetActive (true);
	}

	public void UpdateScore(){
		score++;
		scoreText.text = "Score:" + score.ToString ();
	}
	
	void Update () {
		if (gameOver && Input.GetMouseButton (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}
	}
}
