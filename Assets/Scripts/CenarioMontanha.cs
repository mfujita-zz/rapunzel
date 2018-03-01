using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioMontanha : MonoBehaviour 
{
    public static bool destinoAlcancado = false;

    void Start () 
    {

	}	
	
	void Update ()
    {
        if (Time.timeScale == 0)
            return;
        
        transform.Translate(Vector3.left * .01f);
        if (transform.position.x < -20f && !destinoAlcancado)
        {
            transform.position = new Vector3(18.7f, transform.position.y, transform.position.z);
        }

        if (destinoAlcancado)
        {
            transform.Translate(Vector3.left * 0.05f);

            if (transform.position.x < -4f && gameObject != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
