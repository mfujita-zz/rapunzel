using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transicao1_2 : MonoBehaviour 
{
	public GameObject quarto;
    public GameObject salao;
    public Text aviso;
    public GameObject botao;

    void Start()
    {
        StartCoroutine(Aguarda1s());
        botao.gameObject.SetActive(false);
    }

    IEnumerator Aguarda1s() 
	{
        yield return new WaitForSeconds(1f);
	}

	void Update () 
	{
		if (quarto != null) 
		{            
			quarto.transform.Translate (Vector3.left * 0.05f);
			if (quarto.transform.position.x < -18f) 
			{
				Destroy (quarto);
			}
		}

        if (quarto == null)
        {
//            aviso.text = "Ache os objetos com a lente de aumento.";
//            sala.transform.Translate(Vector3.right * 0.05f);
//            if (sala.transform.position.x > -5.91f)
//            {
//                sala.transform.position = new Vector3(-5.91f, -1.1f, 0);
//            }
            aviso.text = "Hora de cuidar da beleza da Rapunzel.";
            salao.transform.Translate(Vector3.right * 0.05f);
            if (salao.transform.position.x > -5.91f)
            {
                salao.transform.position = new Vector3(-5.91f, -1.1f, 0);
                botao.gameObject.SetActive(true);
            }
        }
	}
}
