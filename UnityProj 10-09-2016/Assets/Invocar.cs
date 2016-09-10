using UnityEngine;

public class Invocar : MonoBehaviour {

	public GameObject prefabCaja;

	float contador = 0f;

	void Start ()
	{
		InvokeRepeating("CrearCaja", 0.5f, 1.0f);


		//CancelInvoke ("CrearCaja");
	}

	/*void Update ()
	{
		contador += Time.deltaTime;

		if (contador > 2f)
		{
			contador = 0.0f;
			Instantiate (prefabCaja, new Vector3 (0, 10, 0), Quaternion.identity);
		}
	}*/

	private void CrearCaja()
	{
		Instantiate (prefabCaja, new Vector3 (0, 10, 0), Quaternion.identity);
	}
}
