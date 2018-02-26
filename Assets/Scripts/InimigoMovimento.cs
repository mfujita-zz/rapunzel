using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour 
{
    public static bool[] liberaInimigos = new bool[4];
    private int indice = 0;

    void Start()
    {
//        for (int i = 0; i < liberaInimigos.Length; i++)
//        {
//            liberaInimigos[i] = false;
//        }
    }

	void Update () 
    {
        transform.Translate(Vector3.left * 0.1f);
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
            liberaInimigos[indice] = true;
            indice++;

        }
//        Debug.Log(indice);
	}
}
