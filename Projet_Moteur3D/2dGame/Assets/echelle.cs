using UnityEngine;
using System.Collections;

public class echelle : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if(Input.GetKey("up")) {
			other.gameObject.transform.position += Vector3.up * (Time.deltaTime*3);
		}

		if(Input.GetKey("down")) {
			other.gameObject.transform.position -= Vector3.up * (Time.deltaTime*2);
		}
	}

}
