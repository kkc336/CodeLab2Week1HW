using UnityEngine;
using System.Collections;

public class RingControl : MonoBehaviour {
	
	public Vector3 originScale;

	public Vector3 currentScale;
	public static float scaleX;
	public static float scaleY;

	public static bool isReset = false;

	void Start () {
		originScale = transform.localScale;
		isReset = false;

	}


	void Update(){
		currentScale = new Vector3(scaleX,scaleY,0);
		transform.localScale = currentScale;

		if(scaleX < 1f){
			scaleX = 1f;
		}

		if(scaleY < 1f){
			scaleY = 1f;
		}

		Reset ();
	}





	void Reset(){
		if(isReset == true){
			
			scaleX = 1f;
			scaleY = 1f;
		isReset = false;

		}
	}


	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "BlueBullet"){
		
			Debug.Log ("hit");

			scaleX -= 0.1f;
			scaleY -= 0.1f;
		}


		if(col.gameObject.tag == "RedBullet"){

			Debug.Log ("hit");
			//currentScale += new Vector3 (0.1f, 0.1f, 0);
			scaleX += 0.1f;
			scaleY += 0.1f;
			Destroy (col.gameObject);
		}


	}
}
