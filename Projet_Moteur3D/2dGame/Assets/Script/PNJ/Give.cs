using UnityEngine;
using System.Collections;

//WENDLING Quentin
public class Give : MonoBehaviour {
	public GameObject[] reserve;
	public Inventaire inv;
	bool canGive=false;
	bool haveElem=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canGive && haveElem) {
			foreach (GameObject elem in reserve) {
				inv.addElem (elem);
			}
			haveElem = false;
		}
	}

	public void OnTriggerEnter2D(){
		canGive = true;
	}

	public void OnTriggerExit2D(){
		canGive = false;
	}
}
