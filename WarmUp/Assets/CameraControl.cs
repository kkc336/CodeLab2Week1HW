using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform player;
	public Transform enemy;

	public Vector3 middlePoint;



	void Start () {
		

	}


	void MiddlePivot(){


		
		middlePoint = (player.position + enemy.position)/2;
		print (middlePoint);
	}


	void Update () {
		MiddlePivot ();
		transform.LookAt (middlePoint);
	}
}
