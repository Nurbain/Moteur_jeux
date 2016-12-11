using UnityEngine;
using System.Collections;

//by Louis Lambrecht
//on work

public class TurretAI : MonoBehaviour {

	public float distance;
	public float wakeRange;
	public float shootInterval;
	public float bulletSpeed = 100;
	public float bulletTimer;

	public bool awake = false;
	public bool lookingRight = true;

	public GameObject bullet;
	public Transform target;
	public Animator anim;
	public Transform shootPointLeft, shootPointRight;


	void Awake(){
		anim = gameObject.GetComponent<Animator> ();
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("Awake", awake);
		anim.SetBool ("LookingRight", lookingRight);

		RangeCheck ();

	}

	void RangeCheck(){
		distance = Vector3.Distance (transform.position, target.transform.position);

		if (distance <= wakeRange) {
			awake = true;
		}

		if (distance > wakeRange) {
			awake = false;
		}

	}



}
