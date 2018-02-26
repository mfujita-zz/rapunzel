using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInimigos : MonoBehaviour 
{
    public static List<bool> liberaInimigos = new List<bool>();
    public static int indice = 0;
    public GameObject plataforma;
    public GameObject rato;
    public GameObject fogo;
    public GameObject bruxa;

	void Start () 
    {
        System.Random r = new System.Random();
        InstanciaPlataformaInimigos(r.Next(0, 3));
  	}

    public void InstanciaPlataformaInimigos(int i)
    {
        if (i == 0) // liberaInimigos[0])
        {
            Instantiate(plataforma, new Vector3(14f, -1.07f, 0), Quaternion.identity);
            Instantiate(fogo, new Vector3(18f, 0.4f, 0), Quaternion.identity);
            Instantiate(bruxa, new Vector3(18f, 3.6f, 0), Quaternion.identity);
        }
        else if (i == 1) // liberaInimigos[0])
        {
            Instantiate(plataforma, new Vector3(14f, -1.07f, 0), Quaternion.identity);
            Instantiate(rato, new Vector3(18f, -3.82f, 0), Quaternion.identity);
            Instantiate(bruxa, new Vector3(18f, 3.6f, 0), Quaternion.identity);
        }
        else if (i == 2) // liberaInimigos[0])
        {
            Instantiate(plataforma, new Vector3(9f, -1.07f, 0), Quaternion.identity);
            Instantiate(plataforma, new Vector3(14f, 1.84f, 0), Quaternion.identity);
            Instantiate(fogo, new Vector3(18f, 0.4f, 0), Quaternion.identity);
            Instantiate(rato, new Vector3(18f, -3.82f, 0), Quaternion.identity);
        }
    }
}
