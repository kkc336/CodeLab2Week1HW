using UnityEngine;
using System.Collections;

public class GetColor : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
	}

	public int GetSpriteColor(){
	
		return Random.Range (0,3f);
	}
}
