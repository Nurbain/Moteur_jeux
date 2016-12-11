using UnityEngine;
using System.Collections;

//By Louis LAMBRECHT

public class PlateformFall : MonoBehaviour {

	private Rigidbody2D rig;
	public float delay = 1.5f;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collider2D col) //le joueur touche la plateforme
	{
		if(col.GetComponent<Collider>().CompareTag("Player")){
				StartCoroutine(Fall());
		}
	}
	
	IEnumerator Fall(){
		yield return new WaitForSeconds(delay); //on attend le delay
		rig.isKinematic = false; //on fait tomber
		GetComponent<Collider2D>().isTrigger = true; //eviter les interactions avec les autres blocs
		yield return 0;
		
	}
}
