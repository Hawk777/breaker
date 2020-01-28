using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	private Rigidbody2D body;
	private Vector2 initialPosition;
	public GameObject ballCountObject;
	private Text ballCountElement;
	private int ballCount;

	void Awake() {
		body = GetComponent<Rigidbody2D>();
		initialPosition = body.position;
		ballCountElement = ballCountObject.GetComponent<Text>();
		ballCount = 0;
	}

	void Start() {
		ballCount = 0;
		UpdateBallCount();
		Launch();
	}

	private void Launch() {
		body.position = initialPosition;
		body.velocity = Vector2.zero;
		StartCoroutine(DelayStart());
	}

	private IEnumerator DelayStart() {
		yield return new WaitForSeconds(2);
		body.velocity = new Vector2(50, 50);
	}

	void FixedUpdate() {
		if(body.position.y < -135) {
			++ballCount;
			UpdateBallCount();
			Launch();
		}
	}

	private void UpdateBallCount() {
		ballCountElement.text = "" + ballCount;
	}
}
