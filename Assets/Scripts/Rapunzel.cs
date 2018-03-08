using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rapunzel : MonoBehaviour 
{
    public float speed = 6.0F;
    public Rigidbody2D rb;
    public bool podePular;
    public bool travaMovimento = true;
    public GameObject[] desabilitaScriptCenarios;
    public static bool destinoAlcancado = false;
    public GameObject bruxa10;
    public GameObject jogarNovamente;
    public GameObject sair;

	void Start () 
    {
        podePular = true;
        jogarNovamente.SetActive(false);
        sair.SetActive(false);
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
        if (jogador.gameObject.name.Equals("Chao") || jogador.gameObject.name.Contains("plataforma"))
        {
            podePular = true;
        }

        if (jogador.gameObject.name.Contains("rato") || jogador.gameObject.name.Contains("bruxa") || jogador.gameObject.name.Contains("fogo"))
        {
            Time.timeScale = 0f;
            jogarNovamente.SetActive(true);
            sair.SetActive(true);
            GameObject musica = GameObject.Find("AudioSource");
            GetComponent<AudioSource>().Stop();
        }

        if (jogador.gameObject.name.Equals("casaFloresta"))
        {
            SceneManager.LoadScene("Final");
        }
    }

    public void ReposionaAoTerminarTrajeto()
    {
        transform.position = new Vector3(-9.8f, -3.4f, transform.position.z);
    }
}
