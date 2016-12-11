using UnityEngine;
using System.Collections;

//By Louis LAMBRECHT

public class PlateformFall : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float delay;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	public void OnCollisionEnter2D(Collision2D col) //le joueur touche la plateforme
	{
		if(col.collider.CompareTag("Player")){
				StartCoroutine(Fall());
		}
	}
	
	IEnumerator Fall(){
		yield return new WaitForSeconds(delay); //on attend le delay
		rb2d.isKinematic = false; //on fait tomber
		yield return 0;
		
	}
}
