using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transicao1_2 : MonoBehaviour 
{
	public GameObject quarto;
    public GameObject sala;

	void Start () 
	{
		
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
            sala.transform.Translate(Vector3.right * 0.05f);
            if (sala.transform.position.x > -5.91f)
            {
                sala.transform.position = new Vector3(-5.91f, 0, 0);
            }
        }
	}
}
