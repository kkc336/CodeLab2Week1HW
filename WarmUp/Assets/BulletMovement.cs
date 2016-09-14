using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float speed = 0.1f;


	void Start () {
	
	}
	

	void FixedUpdate () {
		

		transform.position = transform.position +  transform.right * speed;

	}
}
