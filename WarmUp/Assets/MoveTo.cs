using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		Vector3 dir = Vector3.zero - transform.position;

		rb.MovePosition (transform.position + dir * Time.deltaTime);
	}
}
