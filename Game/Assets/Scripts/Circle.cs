using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	public float speed = 2f;
	void Update () {
		transform.Rotate(Vector3.down * speed * Time.deltaTime);
	}

}
