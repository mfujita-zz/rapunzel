using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transicao1_2 : MonoBehaviour 
{
	public GameObject quarto;

	void Start () 
	{
		
	}

	void Update () 
	{
		if (quarto != null) 
		{
			quarto.transform.Translate (Vector3.left * Time.deltaTime);
			if (quarto.transform.position.x < -18f) 
			{
				Destroy (quarto);
			}
		}
	}
}
