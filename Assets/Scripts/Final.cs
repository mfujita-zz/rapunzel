using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour 
{
    public GameObject elementosUI;

	void Start () 
    {
        elementosUI.SetActive(false);
	}
	
	void Update () 
    {
        transform.Translate(Vector3.left * 0.02f);
        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, transform.position.y, 0);
            elementosUI.SetActive(true);
        }
	}
}
