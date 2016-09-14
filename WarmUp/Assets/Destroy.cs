using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public float timer = 1f;

	void Start () {
		Destroy (gameObject,timer);
	}
	

}
