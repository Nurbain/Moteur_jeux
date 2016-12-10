using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//By Louis LAMBRECHT
//Menu in Game 

public class PauseMenu : MonoBehaviour {
	public bool isPaused;
	public bool muted;
	public GameObject pauseMenuCanvas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
			AudioListener.pause = true;
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
			AudioListener.pause = false;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			isPaused = !isPaused;
		}
			

	}

	public void Resume(){
		isPaused = false;
	}

	public void MainMenu(){
		SceneManager.LoadScene ("ChoixNiveau");
	}



	public void Quit(){
		Application.Quit();
	}
}
