using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour 
{
    private PlataformaInimigos script; //script desse objeto


    void Start()
    {
        script = GameObject.Find("criador").GetComponent<PlataformaInimigos>();
    }

	void Update () 
    {
        transform.Translate(Vector3.left * 0.05f);

        if (transform.position.x < -15f)
        {      
            System.Random r = new System.Random();
            int num = r.Next(0, 3);  //PlataformaInimigos.indice;
            Debug.Log("Sorteado: " + num);
            PlataformaInimigos.liberaInimigos.Add(true);
            script.InstanciaPlataformaInimigos(num);
            PlataformaInimigos.indice++;
            Destroy(gameObject);
        }
	}
}
