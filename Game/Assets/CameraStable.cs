using UnityEngine;

public class CameraStable : MonoBehaviour {
	void Update () {
		this.transform.eulerAngles = new Vector3 (0, this.transform.eulerAngles.y, 0);
	}
}
