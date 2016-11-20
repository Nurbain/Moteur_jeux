using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {
	public GameObject _Past;
	public GameObject _Futur;
	public GameObject _Filter;

	// Use this for initialization
	void Start () {
		_Past.SetActive (true);
		_Futur.SetActive (false);
		_Filter.SetActive (true);
		ChangeTime.isPast = true;
	}

	// Update is called once per frame
	void Update () {

	}
}
