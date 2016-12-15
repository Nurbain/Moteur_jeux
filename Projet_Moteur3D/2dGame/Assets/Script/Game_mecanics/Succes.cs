using UnityEngine;
using System.Collections;


//By Nathan URBAIN
//Script gérent la fin du jeu

public class Succes : MonoBehaviour {


	float tps;
	public GameObject CanvasSucces;

	// Use this for initialization
	void Start () {
		CanvasSucces.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		tps =  Timer.temps;
		print (tps);
		if (other.tag == "Player") {
			CanvasSucces.SetActive(true);
		}
	}

}
