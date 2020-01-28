using UnityEngine;

public class BrickGrid : MonoBehaviour {
	public GameObject prefab;
	public int xCount, yCount;
	public int xStep, yStep;

	void Awake() {
		for(int x = 0; x != xCount; ++x) {
			for(int y = 0; y != yCount; ++y) {
				GameObject clone = Instantiate(prefab, transform);
				clone.transform.Translate(new Vector3(x * xStep, y * yStep, 0));
			}
		}
	}
}
