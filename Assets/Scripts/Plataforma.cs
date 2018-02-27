using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour 
{
	void Update () 
    {
        if (Time.timeScale == 0)
            return;
        
        transform.Translate(Vector3.left * 0.05f);
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
	}
}
