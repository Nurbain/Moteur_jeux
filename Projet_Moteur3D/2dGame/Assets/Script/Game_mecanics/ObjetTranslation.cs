using UnityEngine;
using System.Collections;

//By Nathan URBAIn

public class ObjetTranslation : MonoBehaviour {

	public float x;
	public float y;
	public float z;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void activation()
	{
		transform.Translate(x,y,z);
	}

	public void desactivation()
	{
		transform.Translate(-x, -y, -z);
	}

}
