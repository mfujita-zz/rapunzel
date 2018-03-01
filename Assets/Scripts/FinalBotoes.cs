using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalBotoes : MonoBehaviour 
{
    public void Recomecar()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
