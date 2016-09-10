using UnityEngine;

public class PowerUp : MonoBehaviour {

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

			GameObject go = GameObject.Find("Score Manager");
			ScoreManager sm = go.GetComponent<ScoreManager>();
			sm.score++;

			Destroy (gameObject);
		}
	}

}
