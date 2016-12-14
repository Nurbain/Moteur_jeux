using UnityEngine;
using System.Collections;

//By Nathan Urbain

public class Timer : MonoBehaviour {

	public static float temps = 0 ;
	private string courant;

	public Rect tps;
	public GUISkin skin;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		temps = Time.time;
		courant = string.Format ("{0:0.0}", temps);
	}

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (tps, courant , skin.GetStyle("Timer"));

	}
}
