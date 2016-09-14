using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shoot : MonoBehaviour {

	public List<GameObject> bullets;
	public int poolAmount = 10;

	private string bulletPath = "prefab/BlueJewel";

	void Start () {

	

		bullets = new List<GameObject> ();

		GameObject folder = new GameObject ("Bullets_Folder");



		for(int i = 0; i < poolAmount; i++){

			GameObject obj = Instantiate (Resources.Load(bulletPath)) as GameObject;

			obj.SetActive (false);
			obj.transform.parent = folder.transform;

			bullets.Add (obj);

		}


		InvokeRepeating ("Fire",0.5f, 0.25f);




	}
	

	void Fire(){
	
		for(int i = 0; i < bullets.Count; i++){
			
			if(!bullets[i].activeInHierarchy){
				
				bullets [i].transform.position = transform.position;
				bullets [i].transform.rotation = transform.rotation;
				bullets [i].SetActive (true);
				bullets [i].GetComponent<Animation> ().Play ("JewelIdle");

				break;

			}
	
		}	


	}



}
