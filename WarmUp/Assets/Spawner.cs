using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	private float angle;

	private float x;
	private float y; 
	public float spawnDis = 15f;



	void Start () {
		InvokeRepeating ("Spawn",1f,1f);
	}


	void Update () {
	
	
		angle = Mathf.PI * Random.Range(-10f,10f);

		x = Mathf.Cos (angle) * spawnDis;
		y = Mathf.Sin (angle) * spawnDis;





	}

	void Spawn(){

		Instantiate (Resources.Load ("prefab/RedJewel"), new Vector3 (x, y, 0f), transform.rotation);
	

	}
}
