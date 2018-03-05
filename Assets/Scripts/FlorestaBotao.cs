using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlorestaBotao : MonoBehaviour 
{
//    Scene nomeCena;
//
//    void Awake ()
//    {
//        nomeCena = SceneManager.GetActiveScene();
//    }

    public void ReiniciarFloresta()
    {        
//        SceneManager.LoadScene(nomeCena.ToString(), LoadSceneMode.Single);
        SceneManager.LoadScene("Floresta");
        Time.timeScale = 1;
    }
}
