using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInimigos : MonoBehaviour 
{
    public Transform plataforma;
    public Transform rato;
    public Transform bruxa;

	void Start () 
    {
        Instantiate(plataforma, new Vector3(15.7f, -1.3f, 0), Quaternion.identity);
        Instantiate(rato, new Vector3(22f, -3.82f, 0), Quaternion.identity);


	}

    void Update()
    {
        if (InimigoMovimento.liberaInimigos[0])
        {
            Instantiate(plataforma, new Vector3(15.7f, -1.3f, 0), Quaternion.identity);
            Instantiate(rato, new Vector3(22f, -3.82f, 0), Quaternion.identity);
        }

        if (InimigoMovimento.liberaInimigos[1])
        {
            Instantiate(plataforma, new Vector3(14f, 0f, 0), Quaternion.identity);
            Instantiate(bruxa, new Vector3(22f, 3.5f, 0), Quaternion.identity);
        }

        if (InimigoMovimento.liberaInimigos[2])
        {
            Instantiate(plataforma, new Vector3(28.7f, 0f, 0), Quaternion.identity);
            Instantiate(bruxa, new Vector3(32f, 3.55f, 0), Quaternion.identity);
        }
        Debug.Log("Indices: " + InimigoMovimento.liberaInimigos[0] + " " + InimigoMovimento.liberaInimigos[1] + " " + InimigoMovimento.liberaInimigos[2]);
    }
}
