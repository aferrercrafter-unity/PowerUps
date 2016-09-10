using UnityEngine;

public class CaidaPowerUp : MonoBehaviour
{
	void OnCollisionEnter (Collision colData)
	{
		if (colData.gameObject.name == "Piso")
		{
			Rigidbody miRigidbody = GetComponent<Rigidbody> ();
			Destroy (miRigidbody);

			Collider miCollider = GetComponent<Collider>();
			miCollider.isTrigger = true;
		}
		else
		{
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter (Collider conElQueColisiono)
	{
		if (conElQueColisiono.name == "Pelota")
		{
			Destroy (gameObject);
		}	
	}
}
