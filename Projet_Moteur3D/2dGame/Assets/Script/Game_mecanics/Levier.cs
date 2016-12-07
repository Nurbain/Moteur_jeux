using UnityEngine;
using System.Collections;

//By Nathan URBAIN
//Script pour lier un Levier et un objet à evenement 
//usage : Initialiser le levier dans une rotation de 9°
public class levier : MonoBehaviour {


	bool canactive = false;
	private int compteur = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canactive) {
			if (Input.GetButtonUp ("Action")) {
				if (compteur % 2 == 0) {
					transform.Rotate (0, 0, -18);
					compteur++;

				} else {
					transform.Rotate (0, 0, 18);
					compteur++;
				}
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			canactive = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag == "Player") {
			canactive = false;
		}
	}

}