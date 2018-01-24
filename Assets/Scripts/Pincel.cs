using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pincel : MonoBehaviour 
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;	

	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetMouseButton(0))
        {            
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

            if (transform.position.x < -10)
                transform.position = new Vector3(-10f, transform.position.y);
            if (transform.position.x > 11)
                transform.position = new Vector3(11f, transform.position.y);
            if (transform.position.y < -5)
                transform.position = new Vector3(transform.position.x, -5f);
            if (transform.position.y > 4.9f)
                transform.position = new Vector3(transform.position.x, 4.9f);
            print(transform.position.x + " " + transform.position.y);
        }	
	}
}
