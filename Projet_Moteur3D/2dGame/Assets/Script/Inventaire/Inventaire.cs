using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//WENDLING Quentin
public class Inventaire : MonoBehaviour {
	int _Size=5;
	GameObject[] TabElem;
	int nbelem=0;
	public Sprite defo;
	bool IsActive=true;
	// Use this for initialization
	void Start () {
		TabElem = new GameObject[_Size];
		UpdateTab ();
		gameObject.GetComponent<CanvasGroup>().alpha = 0;
	}

	//Fonction pour ajouter un élément dans l'inventaire return true si l'élément est ajouter false sinon
	public bool addElem(GameObject i){
		//On regarde si on à de la place puis on ajoute l'élément
		if (nbelem < _Size) {
			TabElem [nbelem] = i;
			nbelem++;
			UpdateTab ();
			return true;
		}
		//Si on peut pas on return false
		return false;
	}

	//Fonction qui recherche si un objet est dans l'inventaire puis le supprime
	public bool rechercheAndDel(GameObject elem){
		int i;
		for (i = 0; i < nbelem; i++) {
			if (TabElem [i] == elem) {
				supprElem (i);
				return true;
			}
		}
		return false;
	}

	//Fonction qui supprime un element d'indice i
	void supprElem(int i){
		int j;
		for (j = i; j < nbelem - 1; j++) {
			TabElem [j] = TabElem [j + 1];
		}
		nbelem--;
		UpdateTab();
	}

	//Fonction qui mets a jour le tableau
	void UpdateTab(){
		int i;
		//Si il y à un objet on affiche son sprite 
		for (i = 0; i < nbelem; i++) {
			GameObject.Find ("Obj" + i).GetComponent<Image>().sprite = TabElem[i].GetComponent<SpriteRenderer>().sprite;
		}
		//sinon le sprite par defaut
		for (; i < _Size; i++) {
			GameObject.Find ("Obj" + i).GetComponent<Image>().sprite = defo;
		}
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.I)) {
			print ("press I");
			if(IsActive)
				gameObject.GetComponent<CanvasGroup>().alpha = 0;
			else
				gameObject.GetComponent<CanvasGroup>().alpha = 1;
			IsActive = !IsActive;
		}
	}
}
