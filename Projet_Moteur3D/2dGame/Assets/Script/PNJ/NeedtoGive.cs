using UnityEngine;
using System.Collections;

//WENDLING Quentin
public class NeedtoGive : MonoBehaviour {
	public Inventaire inv;
	public GameObject[] reserve;
	bool canGive=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OkGo(){
		if (canGive) {
			foreach (GameObject elem in reserve) {
				inv.addElem (elem);
			}
			canGive = !canGive;
		}
	}
}
