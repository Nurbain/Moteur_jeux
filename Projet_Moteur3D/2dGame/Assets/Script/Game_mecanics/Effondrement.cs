using UnityEngine;
using System.Collections;

//By Nathan URBAIN

public class Effondrement : MonoBehaviour {

	public GameObject _Objet;
	public GameObject _Objetcache;

	// Use this for initialization
	void Start () {
		_Objet.SetActive (true);
		_Objetcache.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			_Objet.SetActive (false);
			_Objetcache.SetActive (true);
		}
		
	}
}
