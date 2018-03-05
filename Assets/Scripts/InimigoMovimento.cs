using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour 
{
    public GameObject plataforma;
    public GameObject rato;
    public GameObject fogo;
    public GameObject bruxa;
    public Transform bruxa10;

	void Update () 
    {
        if (Time.timeScale == 0)
            return;

        transform.Translate(Vector3.left * 0.05f);

        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        if (bruxa.transform.position.x < 11.4f)
        {
            GameObject risada = GameObject.Find("AudioSource");
            GetComponent<AudioSource>().Play();
        }
	}
}
