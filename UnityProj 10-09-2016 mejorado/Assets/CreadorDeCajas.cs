using UnityEngine;

public class CreadorDeCajas : MonoBehaviour {

	public GameObject prefabCaja;

	float contador = 0f;

	void Update ()
	{
		contador += Time.deltaTime;
		
		if (contador > 2f)
		{
			contador = 0.0f;
			CrearCaja();
		}
	}

	private void CrearCaja()
	{
		Instantiate (prefabCaja, new Vector3 (0, 10, 0), Quaternion.identity);
	}
}
