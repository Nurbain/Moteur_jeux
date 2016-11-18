using UnityEngine;
using System.Collections;

public class CollectObjet : MonoBehaviour {

	public GameObject Objetscene;
	public GameObject Objetinv;
	// Use this for initialization
	void Start () {
		Objetinv.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Objetscene.SetActive (false);
			Objetinv.SetActive (true);
		}
	}
}
