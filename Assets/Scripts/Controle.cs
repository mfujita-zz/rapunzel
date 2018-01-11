using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controle : MonoBehaviour
{
 //https://docs.unity3d.com/Manual/class-SpriteMask.html
 //https://forum.unity.com/threads/make-object-follow-mouse-2d-game.211186/ 

    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    public GameObject colarSemCor;
    public GameObject espelhoSemCor;
    public GameObject oculosSemCor;
    public GameObject perfumeSemCor;
    public GameObject ursinhoSemCor;

	public GameObject colar;
	public GameObject espelho;
	public GameObject oculos;
	public GameObject perfume;
	public GameObject ursinho;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);

            if (transform.position.x < -6.3)
                transform.position = new Vector3(-6.3f, transform.position.y);
            if (transform.position.x > 8.73)
                transform.position = new Vector3(8.7f, transform.position.y);
            if (transform.position.y < -5)
                transform.position = new Vector3(transform.position.x, -5f);
            if (transform.position.y > 4.9f)
                transform.position = new Vector3(transform.position.x, 4.9f);
        }

		if (Input.GetMouseButtonDown(0) && 
			(transform.position.x >= 7.9f && transform.position.y >= 0.48f) &&
			(transform.position.x >= 7.9f && transform.position.y <= 0.92f) &&
			(transform.position.x <= 9.1f && transform.position.y <= 0.92f) &&
			(transform.position.x <= 9.1f && transform.position.y >= 0.48f))
		{
			Destroy(perfumeSemCor);
			Destroy(perfume);
			Debug.Log (DateTime.Now.ToShortTimeString ());
		}

		if (Input.GetMouseButtonDown(0) &&
            (transform.position.x >= 0.4f && transform.position.y >= 3.2f) &&
            (transform.position.x <= 1.0f && transform.position.y <= 3.8f) &&
            (transform.position.x <= 1.0f && transform.position.y <= 3.8f) &&
            (transform.position.x >= 0.4f && transform.position.y >= 3.2f))
        {
            Destroy(ursinhoSemCor);
			Destroy(ursinho);
			Debug.Log ("ursinho");
        }

        if (Input.GetMouseButton(0) &&
            transform.position.x >= -5.5f && transform.position.y >= 0.9f &&
            transform.position.x <= -4.8f && transform.position.y <= 1.5f &&
            transform.position.x <= -4.8f && transform.position.y <= 1.5f &&
            transform.position.x >= -5.5f && transform.position.y >= 0.9f)
        {
            Destroy(oculosSemCor);
			Destroy(oculos);
			Debug.Log ("oculos");
        }

        if (Input.GetMouseButton(0) &&
            transform.position.x >= 1.27f && transform.position.y >= 0.1f &&
            transform.position.x <= 1.7f && transform.position.y <= 3.2f &&
            transform.position.x <= 1.7f && transform.position.y <= 3.2f &&
            transform.position.x >= 1.27f && transform.position.y >= 0.1f)
        {
            Destroy(colarSemCor);
			Destroy(colar);
			Debug.Log ("colar");
        }

        if (Input.GetMouseButton(0) &&
            transform.position.x >= 4.6f && transform.position.y >= -1.7f &&
            transform.position.x <= 5.5f && transform.position.y <= -1.5f &&
            transform.position.x <= 5.5f && transform.position.y <= -1.5f &&
            transform.position.x >= 4.6f && transform.position.y >= -1.7f)
        {
            Destroy(espelhoSemCor);
			Destroy(espelho);
			Debug.Log ("espelho");
        }

		if (perfumeSemCor == null &&
		    ursinhoSemCor == null &&
		    oculosSemCor == null &&
		    colarSemCor == null &&
		    espelhoSemCor == null) 
		{
			SceneManager.LoadScene ("Transicao1_2");
		}
    }
}
