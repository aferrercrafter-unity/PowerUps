using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
	private Rigidbody rb;

	public float fuerza;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	void Update ()
	{
		if (Input.GetKey (KeyCode.UpArrow))
		{
			rb.AddForce (Vector3.forward * fuerza);
		}
		if (Input.GetKey (KeyCode.DownArrow))
		{
			rb.AddForce (Vector3.back * fuerza);
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			rb.AddForce (Vector3.right * fuerza);
		}
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			rb.AddForce (Vector3.left * fuerza);
		}
	}
}
