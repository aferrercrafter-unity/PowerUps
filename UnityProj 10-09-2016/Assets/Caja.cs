using UnityEngine;
using System.Collections;

public class Caja : MonoBehaviour {

	void Start ()
	{
		Destroy (gameObject, 3.0f);
		//Invoke ("Destruirme", 3.0f);
	}

	/*
	void Destruirme()
	{
		Destroy (gameObject);
	}*/
}
