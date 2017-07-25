using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	private float speed;

	void Start(){
		speed = config.SPEED;
	}

	// Update is called once per frame
	void Update () {
		// двигаем стены в сторону ктулху
		this.transform.position += new Vector3(speed*Time.deltaTime, 0f, 0f);

		// уничтожаем их чтоб не забивать память.
		//вдруг кто-то будет достаточно долго играть.
		if(this.transform.position.x < -10) {
			Destroy(this.gameObject);
		}
	}
}
