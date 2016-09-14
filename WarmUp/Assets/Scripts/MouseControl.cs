using UnityEngine;
using System.Collections;

public class MouseControl : MonoBehaviour {

	public Vector3 mousePos;
	public float followSpeed;

	public GameObject prefab;
	public GameObject prefab2;

	void Start () {
	
	}
	

	void Update () {

		if (Input.GetMouseButton (0)) {

			mousePos = Input.mousePosition;
			mousePos = Camera.main.ScreenToWorldPoint (mousePos);
			mousePos.z = 0f;
			//this.gameObject.transform.position = mousePos;
			this.gameObject.transform.position = Vector2.Lerp (transform.position, mousePos, followSpeed); 



		} else if(Input.GetMouseButtonUp(0)){

			RingControl.isReset = true;

			if (RingControl.scaleX > 2f) {
				
				Instantiate (prefab, transform.position, transform.rotation);

				print ("explode");

			} else {
				Instantiate (prefab2, transform.position, transform.rotation);
			}
		}

		else{
			RingControl.isReset = false;


		}

	}
		

}
