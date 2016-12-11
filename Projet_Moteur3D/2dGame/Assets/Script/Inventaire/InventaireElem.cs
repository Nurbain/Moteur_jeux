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
	//On ajoute l'objet dans l'inventaire quant le joueur marche dessus
	void OnTriggerEnter2D(){
		if(inv.addElem (gameObject))
			gameObject.SetActive (false);
	}
}
