using UnityEngine;
using System.Collections;

public class JewelDestroy : MonoBehaviour {

	public float existTime = 3f;

	void OnEnable(){
		
		Invoke ("Destroy", existTime);

	}


	void Destroy(){
	
		this.gameObject.SetActive (false);
	
	} 



	void OnDisable(){
		
		CancelInvoke ();

	}
}

