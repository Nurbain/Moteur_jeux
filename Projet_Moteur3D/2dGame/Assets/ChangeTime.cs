using UnityEngine;
using System.Collections;

public class ChangeTime : MonoBehaviour {
	public GameObject _Past;
	public GameObject _Futur;
	bool isPast=true;
	public GameObject _Filter;
	// Use this for initialization
	void Start () {
		_Past.SetActive (true);
		_Futur.SetActive (false);
		_Filter.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player"){
			if (isPast) {
				_Past.SetActive (false);
				_Futur.SetActive (true);
				_Filter.SetActive (false);
				isPast = false;
			} else {
				_Past.SetActive (false);
				_Futur.SetActive (true);
				_Filter.SetActive (true);
				isPast = true;
			}
		}
	}
}
