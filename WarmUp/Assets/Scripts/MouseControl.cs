using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {

	public Vector3 mousePos;
	public float followSpeed;

	void Start () {
	
	}
	

	void Update () {

		if (Input.GetMouseButton (0)) {

			mousePos = Input.mousePosition;
			mousePos = Camera.main.ScreenToWorldPoint (mousePos);
			mousePos.z = 0f;
			//this.gameObject.transform.position = mousePos;
			this.gameObject.transform.position = Vector2.Lerp(transform.position, mousePos, followSpeed); 



		}

	}
		

}
