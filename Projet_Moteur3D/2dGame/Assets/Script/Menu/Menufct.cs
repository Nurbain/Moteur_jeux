using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//By Nathan URBAIN
//Script des gestions de canvas de menu

public class Menufct : MonoBehaviour {

	public GameObject cmenu;
	public GameObject ccredit;
	public GameObject coption;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Canvas option
	public void option()
	{
		coption.SetActive(true);
		cmenu.SetActive(false);
	}

	//Canvas Credit
	public void Credit()
	{
		ccredit.SetActive(true);
		cmenu.SetActive(false);
	}

	//Debut niveau
	public void Load()
	{
		SceneManager.LoadScene ("ChoixNiveau");
	}

	//Application quit
	public void quitter()
	{
		Application.Quit();
	}

	//Retour fonction credit 
	public void retourc()
	{
		ccredit.SetActive(false);
		cmenu.SetActive(true);
	}

	//Retour fonction
	public void retouro()
	{
		coption.SetActive(false);
		cmenu.SetActive(true);
	}
}
