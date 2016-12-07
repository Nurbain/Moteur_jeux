using UnityEngine;
using System.Collections;

//By Quentin & Nathan 
//Système d'ascensseur

public class ascenseur : MonoBehaviour {

	private float length;
	private bool avance = true;
	private float _progress;
	public float _speed;
	public GameObject depart;
	public GameObject arriver;



	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (avance) {
			_progress = Mathf.Clamp01 (_progress + _speed * Time.deltaTime / (arriver.transform.position - depart.transform.position).magnitude);
			if (_progress == 1.0f) {
				avance = false;
			}
		}else {
			_progress = Mathf.Clamp01 (_progress - _speed * Time.deltaTime / (arriver.transform.position - depart.transform.position).magnitude);
			if (_progress == 0.0f) {
				avance = true;
			}
		}

		transform.position = Vector2.Lerp(depart.transform.position, arriver.transform.position, _progress);
	}
}