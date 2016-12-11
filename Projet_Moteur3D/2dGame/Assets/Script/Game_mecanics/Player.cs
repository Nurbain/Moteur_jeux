using UnityEngine;
using System.Collections;

//By Louis LAMBRECHT

public class Player : MonoBehaviour {

	public int currHealth;
	public int maxHealth = 5;
	
	public Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		currHealth = maxHealth;
		rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(currHealth > maxHealth){
			currHealth = maxHealth;
		}
		if(currHealth <= 0){
			Die();
		}
	}

	void Die(){
		Application.LoadLevel(Application.loadedLevel);
		
	}
	
	void Damage(int n){
		currHealth -= n;
	}
	
	public IEnumerator Knockback float knockD, float knockPwr, Vector3 direction){
		float timer = 0;
		while(knockD > timer){
			timer += Time.deltaTime;
			rb2d.AddForce(new Vector3(direction.x * -100, direction.y knockPwr, transform.position.z));
		}
		
		yield return 0;
		
	}
	
}
