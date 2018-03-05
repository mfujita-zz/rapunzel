using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaInimigos : MonoBehaviour 
{
    public GameObject bruxa10;
    public Rapunzel rapunzel;

    void Start()
    {
        
    }

    void Update()
    {
        if (bruxa10 == null)
        {
            Cenario.destinoAlcancado = true;
            CenarioMontanha.destinoAlcancado = true;
            BarraProgresso.destinoAlcancado = true;

            rapunzel.GetComponent<Rapunzel>().ReposionaAoTerminarTrajeto();
            this.enabled = false;
        }
    }
}
