using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInimigos : MonoBehaviour 
{
    public Transform plataforma;
    public Transform rato;

	void Start () 
    {
        Instantiate(plataforma, new Vector3(15.7f, -1.5f, 0), Quaternion.identity);
        Instantiate(rato, new Vector3(22f, -3.82f, 0), Quaternion.identity);

        Instantiate(plataforma, new Vector3(21.7f, 0f, 0), Quaternion.identity);
        Instantiate(rato, new Vector3(30f, -3.82f, 0), Quaternion.identity);
	}
}
