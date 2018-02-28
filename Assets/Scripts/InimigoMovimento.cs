using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour 
{
    //private PlataformaInimigos script; //script desse objeto

    public GameObject plataforma;
    public GameObject rato;
    public GameObject fogo;
    public GameObject bruxa;
    public GameObject bruxa10;

    void Start()
    {
        //script = GameObject.Find("criador").GetComponent<PlataformaInimigos>();
        bruxa10 = GameObject.FindWithTag("bruxa10");
    }

	void Update () 
    {
        if (Time.timeScale == 0)
            return;

        transform.Translate(Vector3.left * 0.05f);

        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        if (bruxa10 == null)
        {            
            //            Time.timeScale = 0;
            Cenario.destinoAlcancado = true;
        }
        Debug.Log("Bruxa: " + Cenario.destinoAlcancado);
	}
}


//            System.Random r = new System.Random();
//            int num = r.Next(0, 3);
//            if (num == 0) 
//            {
//                Instantiate(plataforma, new Vector3(13f, -1.07f, 0), Quaternion.identity);
//                Instantiate(fogo, new Vector3(15f, 0.4f, 0), Quaternion.identity);
//                Instantiate(bruxa, new Vector3(15f, 3.6f, 0), Quaternion.identity);
//                plataforma.transform.position = new Vector3(13f, -1.07f, 0);
//                fogo.transform.position = new Vector3(15f, 0.4f, 0);
//                bruxa.transform.position = new Vector3(15f, 3.6f, 0);
//            }
//            else if (num == 1) 
//            {
//                Instantiate(plataforma, new Vector3(13f, -1.07f, 0), Quaternion.identity);
//                Instantiate(rato, new Vector3(15f, -3.82f, 0), Quaternion.identity);
//                Instantiate(bruxa, new Vector3(15f, 3.6f, 0), Quaternion.identity);
//                plataforma.transform.position = new Vector3(13f, -1.07f, 0);
//                fogo.transform.position = new Vector3(15f, -3.82f, 0);
//                bruxa.transform.position = new Vector3(15f, 3.6f, 0);
//            }
//            else if (num == 2) 
//            {
//                Instantiate(plataforma, new Vector3(9f, -1.07f, 0), Quaternion.identity);
//                Instantiate(plataforma, new Vector3(14f, 1.84f, 0), Quaternion.identity);
//                Instantiate(fogo, new Vector3(18f, 0.4f, 0), Quaternion.identity);
//                Instantiate(rato, new Vector3(18f, -3.82f, 0), Quaternion.identity);
//                plataforma.transform.position = new Vector3(9f, -1.07f, 0);
//                plataforma.transform.position = new Vector3(14f, 1.84f, 0);
//                fogo.transform.position = new Vector3(18f, 0.4f, 0);
//                bruxa.transform.position = new Vector3(18f, -3.82f, 0);
//            }


//        if (transform.position.x < -12f)
//        {      
//            System.Random r = new System.Random();
////            int num = r.Next(0, 3);  //PlataformaInimigos.indice;
////            Debug.Log("Sorteado: " + num);
////            PlataformaInimigos.liberaInimigos.Add(true);
////            script.InstanciaPlataformaInimigos(num);
////            PlataformaInimigos.indice++;
//            script.InstanciaPlataformaInimigos();
//            Destroy(gameObject);
//        }