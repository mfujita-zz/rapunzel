using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gerenciador : MonoBehaviour 
{
	public void CarregaCena()
	{
        Scene cena = SceneManager.GetActiveScene();

        if (cena.name.Equals ("Intro")) 
        {
			SceneManager.LoadScene ("FugaInstrucao");
		} 
		else if (cena.name.Equals ("FugaInstrucao")) 
        {
            SceneManager.LoadScene("FugaJogo");
		}
	}
}
