using UnityEngine;
using System.Collections;

[RequireComponent (typeof (SpriteRenderer))]

//Modified by Quentin Wendling & Nathan Urbain 

public class RepeatSpriteBoundary : MonoBehaviour {
	SpriteRenderer sprite;

	int pgcd(int a,int b){
		if (a < b)
			return pgcd (b, a);
		int q = a / b;
		if (a == b * q) {
			return b;
		}
		return pgcd (b, a - b * q);
	}

	float SizeSprite(float tx,float ty){
		int k = 1;
		float s,tmp;
		while (true) {
			s = tx / (float)k;
			tmp = (int)Mathf.Round (ty / s) - ty / s;
			if (tmp < 0.0001 && tmp > -0.0001) {
				return s;
			}
			k++;
		}
	}

	void Awake () {

		sprite = GetComponent<SpriteRenderer>();
		Vector2 spriteSize = new Vector2(sprite.bounds.size.x / transform.localScale.x, sprite.bounds.size.y / transform.localScale.y);
		// Generate a child prefab of the sprite renderer
		GameObject childPrefab = new GameObject();
		SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer>();
		childPrefab.transform.position = transform.position;
		childSprite.sprite = sprite.sprite;

		// Loop through and spit out repeated tiles
		GameObject child;
		int dx, dy;
		if (transform.localScale.x > transform.localScale.y) {
			print ("x>y");
			dx = 4;
			dy = 2;
		} else {
			dy = 5;
			dx = 4;
		}

		for (float i = -sprite.bounds.size.y+dy, l = sprite.bounds.size.y; i < l-(dy-1); i++) {
			for (float j = -sprite.bounds.size.x+dx, k =sprite.bounds.size.x; j < k-(dx-1); j++) {
				child = Instantiate (childPrefab) as GameObject;
				child.transform.position = transform.position - (new Vector3 (spriteSize.x * j, spriteSize.y*i, 0));
				child.transform.parent = transform;
			}
		}




		// Set the parent last on the prefab to prevent transform displacement
		childPrefab.transform.parent = transform;

		// Disable the currently existing sprite component since its now a repeated image
		sprite.enabled = false;
	}
}