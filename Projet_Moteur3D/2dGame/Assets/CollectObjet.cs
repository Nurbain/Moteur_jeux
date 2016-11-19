using UnityEngine;
using System.Collections;

public class CollectObjet : MonoBehaviour {

	public GameObject Objetscene;
	public GameObject ObjetinvF;
	public GameObject ObjetinvP;
	// Use this for initialization
	void Start () {
		ObjetinvF.SetActive(false);
		ObjetinvP.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			Objetscene.SetActive (false);
			ObjetinvF.SetActive (true);
			ObjetinvP.SetActive (true);
		}
	}
}
