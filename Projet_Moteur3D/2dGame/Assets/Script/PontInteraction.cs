using UnityEngine;
using System.Collections;

public class PontInteraction : MonoBehaviour {
	public GameObject elements;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<CanvasGroup>().alpha = 0;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
		elements.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OkGo(){
		gameObject.GetComponent<CanvasGroup>().alpha = 1;
		gameObject.GetComponent<BoxCollider2D> ().enabled = true;
		elements.SetActive (true);
	}
}
