using UnityEngine;

public class PowerUp : MonoBehaviour {

	//public ScoreManager scoreManagerComponent;

	void OnTriggerEnter(Collider other)
	{
		if (other.name == "Bola")
		{
			MeshRenderer mr = other.GetComponent<MeshRenderer> ();
			mr.material.color = Color.yellow;

			Rigidbody rb = other.GetComponent<Rigidbody> ();
			rb.Sleep ();

			Bola b = other.GetComponent<Bola> ();
			b.AgarrarPowerUp ();
			//other.GetComponent<Bola> ().AgarrarPowerUp ();

			//ScoreManager.score++; // cuando es publico

			//GameObject go = GameObject.Find ("Score Manager");
			//go.SendMessage ("AumentarPuntaje");

			//scoreManagerComponent.score++;

			//ScoreManager sm = scoreManagerObject.GetComponent<ScoreManager>();
			//sm.score++;

			Destroy (gameObject);
		}
	}

}
