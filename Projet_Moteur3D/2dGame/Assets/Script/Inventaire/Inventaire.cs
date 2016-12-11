using UnityEngine;
using System.Collections;
using UnityEngine.UI;


//WENDLING Quentin
public class Inventaire : MonoBehaviour {
	int _Size=5;
	GameObject[] TabElem;
	int nbelem=0;
	public Sprite defo;
	// Use this for initialization
	void Start () {
		TabElem = new GameObject[_Size];
		UpdateTab ();
	}

	public void addElem(GameObject i){
		if (nbelem < _Size) {
			TabElem [nbelem] = i;
			nbelem++;
			UpdateTab ();
		}
	}

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

	void supprElem(int i){
		int j;
		for (j = i; j < nbelem - 1; j++) {
			TabElem [j] = TabElem [j + 1];
		}
		nbelem--;
		UpdateTab();
	}

	void UpdateTab(){
		int i;
		for (i = 0; i < nbelem; i++) {
			GameObject.Find ("Obj" + i).GetComponent<Image>().sprite = TabElem[i].GetComponent<SpriteRenderer>().sprite;
		}
		for (; i < _Size; i++) {
			GameObject.Find ("Obj" + i).GetComponent<Image>().sprite = defo;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
