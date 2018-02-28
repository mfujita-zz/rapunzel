using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraProgresso : MonoBehaviour 
{
    public GameObject rapunzel;
    public Slider progresso;
    public GameObject[] inimigos = new GameObject[10];

	void Update () 
    {        
        if (inimigos[0] == null)
            progresso.value = 0.1f; 
        if (inimigos[0] == null && inimigos[1] == null)
            progresso.value = 0.2f; 
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null)
            progresso.value = 0.3f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null)
            progresso.value = 0.4f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null)
            progresso.value = 0.5f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null &&
            inimigos[5] == null)
            progresso.value = 0.6f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null &&
            inimigos[5] == null && inimigos[6] == null)
            progresso.value = 0.7f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null &&
            inimigos[5] == null && inimigos[6] == null && inimigos[7] == null)
            progresso.value = 0.8f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null &&
            inimigos[5] == null && inimigos[6] == null && inimigos[7] == null && inimigos[8] == null)
            progresso.value = 0.9f;
        if (inimigos[0] == null && inimigos[1] == null && inimigos[2] == null && inimigos[3] == null && inimigos[4] == null &&
            inimigos[5] == null && inimigos[6] == null && inimigos[7] == null && inimigos[8] == null && inimigos[9] == null)
            progresso.value = 1.0f;
	}
}
