using UnityEngine;
using System.Collections;


//By Nathan URBAIN
//Script gérent la collect d'objet 

public class Succes : MonoBehaviour {

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
		if (other.tag == "Player") {
			CanvasSucces.SetActive (true);
		}
	}
}
