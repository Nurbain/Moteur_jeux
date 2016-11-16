using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menufct : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void option()
	{
	
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
}
