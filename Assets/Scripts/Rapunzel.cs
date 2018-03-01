using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rapunzel : MonoBehaviour 
{
    public float speed = 6.0F;
    public Rigidbody2D rb;
    public bool podePular;

    public GameObject[] desabilitaScriptCenarios;
    public static bool destinoAlcancado = false;

	void Start () 
    {
        podePular = true;
        //desabilitaScript = GameObject.Find("Cenario");
	}	

	void Update () 
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * 0.08f);
            if (transform.position.x > 10.5f)
            {
                transform.position = new Vector3(10.5f, transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * 0.08f);
            if (transform.position.x < -10.3f)
            {
                transform.position = new Vector3(-10.3f, transform.position.y, transform.position.z);
            }
        }

        if (Cenario.destinoAlcancado)
        {
            transform.Translate(Vector3.left * 0.4f);
            if (transform.position.x < -9.5f)
            {
                transform.position = new Vector3(-9.5f, transform.position.y, transform.position.z);
            }
        }
	}

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && podePular)
        {
            rb.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
            podePular = false;
        }
    }

    void OnCollisionEnter2D(Collision2D jogador)
    { 
        if (jogador.gameObject.name.Equals("rodape") || jogador.gameObject.name.Contains("plataforma"))
        {
            podePular = true;
        }

//        if ()
//        {
//            podePular = true;
//        }

        if (jogador.gameObject.name.Contains("rato") || jogador.gameObject.name.Contains("bruxa") || jogador.gameObject.name.Contains("fogo"))
        {
            Time.timeScale = 0f;
        }
    }
}
