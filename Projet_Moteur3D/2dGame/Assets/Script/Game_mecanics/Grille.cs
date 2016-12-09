using UnityEngine;
using System.Collections;

public class Grille : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activation()
	{
		transform.Translate(0, -4, 0);
	}

	public void desactivation()
	{
		transform.Translate(0, 4, 0);
	}
}
