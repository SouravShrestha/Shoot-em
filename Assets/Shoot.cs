using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject pin;

	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			makePin();
		}
	}

	void makePin()
	{
		Instantiate (pin, transform.position, transform.rotation);
	}
}
