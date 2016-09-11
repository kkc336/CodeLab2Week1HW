using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float speed = 0.1f;


	void Start () {
	
	}
	

	void FixedUpdate () {
		
		//print (LookAt.direction);
		transform.position = transform.position +  transform.right* -1f * speed;

	}
}
