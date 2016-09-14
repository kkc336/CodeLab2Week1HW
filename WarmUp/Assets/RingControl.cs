using UnityEngine;
using System.Collections;

public class RingControl : MonoBehaviour {
	
	public Vector3 originScale;

	void Start () {
		originScale = transform.localScale;
	}





	void Reset () {
			transform.localScale = originScale;
	}




	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "BlueBullet"){
		
			Debug.Log ("hit");
			transform.localScale -= new Vector3 (0.1f, 0.1f, 0);
		}


		if(col.gameObject.tag == "RedBullet"){

			Debug.Log ("hit");
			transform.localScale += new Vector3 (0.1f, 0.1f, 0);
			Destroy (col.gameObject);
		}


	}
}
