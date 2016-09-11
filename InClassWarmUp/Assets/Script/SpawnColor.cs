using UnityEngine;
using System.Collections;

public class SpawnColor : MonoBehaviour {

	public Sprite[] sprites;


	void Start () {
		InvokeRepeating ("Spawn",1,1);
	}
	

	void Update () {
	
	}

	void Spawn(){
		GameObject go = Instantiate (Resources.Load ("Prefabs/Color")) as GameObject;
		//
	
	}
}
