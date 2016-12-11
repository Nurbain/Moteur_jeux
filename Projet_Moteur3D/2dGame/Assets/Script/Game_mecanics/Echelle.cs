using UnityEngine;
using System.Collections;

//By Nathan URBAIN
//Script permetant le mecanisme d'echelle

public class Echelle : MonoBehaviour {

	private bool _isin = false;
	public GameObject perso;
	private Rigidbody2D gravity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(_isin == true) {
			gravity = perso.GetComponent<Rigidbody2D>();
			gravity.gravityScale = 0;			
			if (Input.GetKey ("up")) {
				perso.transform.position += Vector3.up * (Time.deltaTime * 6);
			}

			if (Input.GetKey ("down")) {
				perso.transform.position -= Vector3.up * (Time.deltaTime * 6);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D player)
	{
		if (player.tag == "Player") {
			_isin = true;
		}
	}

	void OnTriggerExit2D(Collider2D player)
	{
		_isin = false;
		print ("yoyo");
		gravity = perso.GetComponent<Rigidbody2D>();
		gravity.gravityScale = 3;		
	}

}
