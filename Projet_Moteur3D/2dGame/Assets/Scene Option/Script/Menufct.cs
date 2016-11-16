using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menufct : MonoBehaviour {

	public GameObject coption;
	public GameObject cmenu;
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
	
	}

	public void start()
	{
		SceneManager.LoadScene ("Game");
	}

	public void quitter()
	{
		Application.Quit();
	}

	public void retour()
	{
		coption.SetActive(false);
		cmenu.SetActive(true);
	}
}
