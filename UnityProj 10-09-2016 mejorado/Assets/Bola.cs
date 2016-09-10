using UnityEngine;

public class Bola : MonoBehaviour {

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (Input.anyKeyDown)
		{
			rb.AddForce (Vector3.forward * 5, ForceMode.Impulse);
		}
	}

	public void AgarrarPowerUp()
	{
		name = "Bola con Power Up";

		// otro conjunto de cosas para cuando agarro powerup
	}
}
