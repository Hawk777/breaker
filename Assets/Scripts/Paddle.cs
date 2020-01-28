using UnityEngine;

public class Paddle : MonoBehaviour {
	void Update() {
		const float playFieldWidth = 384f;
		float normalizedPosition = Input.mousePosition.x * 2f / Screen.width - 1f;
		float paddleWidth = transform.localScale.x * 0.25f;
		float maxPaddleDistance = (playFieldWidth - paddleWidth) * 0.5f;
		float paddleCentre = normalizedPosition * maxPaddleDistance;
		float paddleLeft = paddleCentre - paddleWidth * 0.5f;
		transform.localPosition = new Vector2(paddleLeft, transform.localPosition.y);
	}
}
