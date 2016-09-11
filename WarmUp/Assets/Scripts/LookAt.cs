using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	public Transform target;
	public float lookSpeed = 1f;
	public static Vector3 direction;

	void Start () {
	
	}
	

	void Update () {

		Vector3 direction = target.position - transform.position;
		direction.z = 0;

		//need to fix the rotation bug
		transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.FromToRotation(transform.position,direction),lookSpeed * Time.deltaTime);
	}
}
