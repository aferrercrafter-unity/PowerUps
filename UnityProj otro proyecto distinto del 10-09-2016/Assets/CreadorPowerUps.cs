using UnityEngine;

public class CreadorPowerUps : MonoBehaviour {

	public GameObject prefabPowerUp;

	void Start ()
	{
		InvokeRepeating ("CrearPowerUp", 1.0f, 2.0f);	
	}

	void CrearPowerUp ()
	{
		Vector3 posDondeCrearlo = new Vector3 (Random.Range (-10, 10), 10, Random.Range (-10, 10)); 
		
		GameObject objetoInstanciado = (GameObject)Instantiate (prefabPowerUp, posDondeCrearlo, Quaternion.identity);
	}
}
