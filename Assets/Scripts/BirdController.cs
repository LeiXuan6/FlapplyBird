using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Animator animator;
	public AudioSource flyAudio;
	public AudioSource deadAudio;
	public AudioSource scoreAudio;

	public float force = 200f;
	private static readonly float IDLE_WAIT_TIME_SEC = 0.3f;
	private float flyAfterTimeSec = 0f;

	void Start () {
		//获取当前游戏精灵的Rigidbody2D组件
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	void Update () {
		if (!GameController.getInstance().isGameOver()) {
			float delta = UnityEngine.Time.deltaTime;
			flyAfterTimeSec += delta;

			//检测鼠标左键是否按下
			if (Input.GetMouseButtonDown (0)) {
				//向刚体施加一个有方向的力
				rb2d.AddForce (new Vector2 (0, force));
				flyAudio.Play ();
				animator.SetBool ("Fly", true);
				flyAfterTimeSec = 0f;

			} else {
				
				if (flyAfterTimeSec >= IDLE_WAIT_TIME_SEC) {
					animator.SetBool ("Fly", false);
				}

			}
		}
			
	}

	void OnCollisionEnter2D(Collision2D collsion){
		GameController.getInstance ().BirdDead ();
		deadAudio.Play ();
		animator.SetBool ("Dead", true);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.name.Contains("Decoration")){
			scoreAudio.Play ();
			GameController.getInstance ().UpdateScore ();
		}
	}
}
