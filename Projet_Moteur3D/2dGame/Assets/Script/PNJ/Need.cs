using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//WENDLING Quentin
public class Need : MonoBehaviour {
	public List<GameObject> needList=new List<GameObject>();
	bool canTake=false;
	public Inventaire inv;
	public GameObject interact;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (canTake) {
			needList.ForEach (delegate(GameObject elem) {
				if(inv.rechercheAndDel(elem))
					needList.Remove(elem);
			});
			if (needList.Count == 0) {
				interact.SendMessage ("OkGo");
			}
		}
	}

	public void OnTriggerEnter2D(){
		canTake = true;
	}

	public void OnTriggerExit2D(){
		canTake = false;
	}
}
