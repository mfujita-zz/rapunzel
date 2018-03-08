using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour 
{
    public Transform casaFloresta;
    public static bool destinoAlcancado;
	
	void Start () 
    {
        destinoAlcancado = false;
	}	
	
	void Update () 
    {
        if (Time.timeScale == 0 && destinoAlcancado == false)
        {
            return;
        }

        transform.Translate(Vector3.left * .05f);
        if (transform.position.x < -20f && !destinoAlcancado)
        {
            transform.position = new Vector3(18.7f, transform.position.y, transform.position.z);
        }

        if (destinoAlcancado)
        {
            transform.Translate(Vector3.left * .05f);
            if (transform.position.x < -20f && gameObject != null)
            {
                Destroy(gameObject);
            }

            casaFloresta.Translate(Vector3.left * .05f);
            if (casaFloresta.transform.position.x < 0f)
            {
                casaFloresta.position = new Vector3(0f, transform.position.y, transform.position.z);
            }
        }
	}
}
