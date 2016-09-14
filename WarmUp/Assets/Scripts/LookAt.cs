using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	public Transform target;
	public float lookSpeed = 1f;
	public Vector3 direction;

	void Start () {
	
	}
	

	void Update () {

		Vector3 direction = transform.position - target.position ;
		direction.z = 0;




		transform.rotation = Quaternion.Slerp(this.transform.rotation,Quaternion.FromToRotation(transform.position,direction),lookSpeed * Time.deltaTime);
	}
}
