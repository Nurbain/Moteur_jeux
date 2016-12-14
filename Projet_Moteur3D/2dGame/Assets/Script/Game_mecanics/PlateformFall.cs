using UnityEngine;
using System.Collections;

//By Louis LAMBRECHT

public class PlateformFall : MonoBehaviour {

	private Rigidbody2D rb2d;
	private float delay = 0.7f;
	private float reAppDelay = 4.0f;

	private bool falling = false;

	public Vector3 vect;



	// Use this for initialization
	void Start () {
		vect = gameObject.transform.position;
		rb2d = GetComponent<Rigidbody2D>();
	}

	public void OnCollisionEnter2D(Collision2D col) //le joueur touche la plateforme
	{
		if (falling == false){
			if (col.collider.CompareTag ("Player")) {
				StartCoroutine (Fall ());
				StartCoroutine (reApp ());
			}
		}
	}
	
	IEnumerator Fall(){
		falling = true;
		yield return new WaitForSeconds(delay); //on attend le delay
		rb2d.isKinematic = false; //on fait tomber
		yield return 0;
		
	}

	IEnumerator reApp(){
		yield return new WaitForSeconds(reAppDelay);
		rb2d.isKinematic = true;
		transform.position = vect;
		transform.rotation = Quaternion.Euler(0, 0, 0);
		falling = false;
		yield return 0;
	}
}
