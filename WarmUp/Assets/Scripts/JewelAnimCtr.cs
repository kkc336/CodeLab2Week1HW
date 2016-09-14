using UnityEngine;
using System.Collections;

public class JewelAnimCtr : MonoBehaviour {

	private Animation anim;

	void Start(){

		anim = GetComponent<Animation> ();


	}




	void OnCollisionEnter2D(Collision2D col){
		
		if(col.gameObject.tag == "Ring"){

			anim.Play ("JewelAnim");

		}
	}

}
