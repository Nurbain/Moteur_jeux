using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

//By Nathan URBAIN
//Script gérant le surlignage de bouton dans le menu

public class hightlighted : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler{
	// Use this for initialization
	public GameObject droit;
	public GameObject gauche;

	void Start () {
		droit.SetActive (false);
		gauche.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnPointerEnter(PointerEventData eventData)
	{
			droit.SetActive (true);
			gauche.SetActive (true);
	}

	public void OnPointerExit (PointerEventData eventData)
	{
		droit.SetActive (false);
		gauche.SetActive (false);
	}

}
