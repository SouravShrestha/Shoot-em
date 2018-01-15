using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinMovement1 : MonoBehaviour {

	public float speed = 10f;
	public Rigidbody2D rb;
	private bool touched = false;

	void Update(){
		if(!touched)
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "ROTATOR") {
			transform.SetParent (col.transform);
			touched = true;
		}
	}
}
