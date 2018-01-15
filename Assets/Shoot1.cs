using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour {

	public GameObject pin;
	void makePin()
	{
		Instantiate (pin, transform.position, transform.rotation);
	}

    void Rem()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("PIN");
        Destroy(items[0]);
    }
}
