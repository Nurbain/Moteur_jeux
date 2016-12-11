using UnityEngine;
using System.Collections;


//WENDLING Quentin
public class InventaireElem : MonoBehaviour {
	public Inventaire inv;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(){
		inv.addElem (this);
		gameObject.SetActive (false);
	}
}
