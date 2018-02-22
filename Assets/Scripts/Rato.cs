using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rato : MonoBehaviour 
{
	void Update () 
    {
        transform.Translate(Vector3.left * 0.1f);
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
	}
}
