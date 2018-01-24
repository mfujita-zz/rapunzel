using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudancaCorUnhas : MonoBehaviour 
{
    private Renderer rend;

	void Start () 
    {
        rend = GetComponent<Renderer>();
	}	

	void Update () 
    {
        
	}

    void OnCollisionEnter2D(Collision2D unha)
    {
        rend.material.color = BotaoCor.cor;
    }
}
