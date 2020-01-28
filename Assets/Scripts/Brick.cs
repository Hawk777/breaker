using UnityEngine;

public class Brick : MonoBehaviour {
	private bool cracked;
	private SpriteRenderer crackRenderer;

	void Awake() {
		cracked = false;
		crackRenderer = transform.Find("Cracks").gameObject.GetComponent<SpriteRenderer>();
		SpriteRenderer mainRenderer = transform.Find("Brick").gameObject.GetComponent<SpriteRenderer>();
		Color c = Random.ColorHSV(0, 1, 0, 1, 1, 1);
		mainRenderer.color = c;
		crackRenderer.color = c;
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(!cracked) {
			crackRenderer.enabled = true;
			cracked = true;
		} else {
			Destroy(gameObject);
		}
	}
}
