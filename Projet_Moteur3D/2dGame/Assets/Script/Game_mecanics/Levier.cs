using UnityEngine;
using System.Collections;


//By Nathan URBAIN
//Script pour lier un Levier et un objet à evenement 
//usage : Initialiser le levier dans une rotation de 18° ,init -12
public class Levier : MonoBehaviour {


	bool canactive = false;
	private int compteur = 0;
	public GameObject _Objetlie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canactive) {
			if (Input.GetButtonUp ("Action")) {
				if (compteur % 2 == 0) {
					transform.Rotate (0, 0, -36);
					_Objetlie.SendMessage ("activation");
					compteur++;

				} else {
					transform.Rotate (0, 0, 36);
					_Objetlie.SendMessage ("desactivation");
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