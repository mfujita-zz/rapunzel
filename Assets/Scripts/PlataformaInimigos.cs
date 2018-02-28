using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInimigos : MonoBehaviour 
{
    public GameObject bruxa10;

    void Update()
    {
        if (bruxa10 == null)
        {
            Cenario.destinoAlcancado = true;
        }
    }
}
