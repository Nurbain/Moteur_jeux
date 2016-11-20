using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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


	public void option()
	{
		coption.SetActive(true);
		cmenu.SetActive(false);
	}

	public void Credit()
	{
		ccredit.SetActive(true);
		cmenu.SetActive(false);
	}

	public void start()
	{
		SceneManager.LoadScene ("Niveau1");
	}

	public void quitter()
	{
		Application.Quit();
	}

	public void retour()
	{
		ccredit.SetActive(false);
		cmenu.SetActive(true);
	}
}
