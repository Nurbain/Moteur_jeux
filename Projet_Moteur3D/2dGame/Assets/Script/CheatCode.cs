using UnityEngine;
using System.Collections;

//Nathan URBAIN 
//Utilisation du cheatCode

public class CheatCode : MonoBehaviour {

	public bool isCheated;
	public GameObject CheatPanel;
	public GameObject perso;
	private bool _ison = false;
	private Rigidbody2D gravity;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (isCheated) {
			CheatPanel.SetActive (true);
			Time.timeScale = 0f;
		} else {
			Time.timeScale = 1f;
			CheatPanel.SetActive (false);
		}

		if(Input.GetKeyDown(KeyCode.C))
			isCheated = !isCheated;

		if (_ison == true) {
			if (Input.GetKey ("up")) {
				perso.transform.position += Vector3.up * (Time.deltaTime * 6);
			}

			if (Input.GetKey ("down")) {
				perso.transform.position -= Vector3.up * (Time.deltaTime * 6);
			}
		}
	}

	public void no()
	{
		CheatPanel.SetActive (false);
		isCheated = false;
		_ison = false;
		gravity = perso.GetComponent<Rigidbody2D> ();
		gravity.gravityScale = 3;
	}
		
	public void yes()
	{
		CheatPanel.SetActive (false);
		isCheated = false;
		_ison = true;
		gravity = perso.GetComponent<Rigidbody2D> ();
		gravity.gravityScale = 0;
	}
}
