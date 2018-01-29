using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unhas : MonoBehaviour 
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    public GameObject direitaMinimo;
    public GameObject direitaAnular;
    public GameObject direitaMedio;
    public GameObject direitaIndicador;
    public GameObject direitaPolegar;

    public GameObject esquerdaPolegar;
    public GameObject esquerdaIndicador;
    public GameObject esquerdaMedio;
    public GameObject esquerdaAnular;
    public GameObject esquerdaMinimo;

    public GameObject rapunzel_unhas;
    private List<GameObject> maos = new List<GameObject>();
    public Text instrucao;

    public GameObject pincel;
    public GameObject esmalteVermelho;
    public GameObject esmalteRosa;
    public GameObject esmalteRoxo;
    public GameObject esmalteCoco;

    public GameObject proximaFase;

    void Start()
    {
        direitaMinimo.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        direitaAnular.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        direitaMedio.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        direitaIndicador.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        direitaPolegar.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);

        esquerdaPolegar.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        esquerdaIndicador.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        esquerdaMedio.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        esquerdaAnular.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);
        esquerdaMinimo.transform.position = new Vector2(rapunzel_unhas.transform.position.x, rapunzel_unhas.transform.position.y);

        maos.Add(direitaMinimo);
        maos.Add(direitaAnular);
        maos.Add(direitaMedio);
        maos.Add(direitaIndicador);
        maos.Add(direitaPolegar);
        maos.Add(esquerdaPolegar);
        maos.Add(esquerdaIndicador);
        maos.Add(esquerdaMedio);
        maos.Add(esquerdaAnular);
        maos.Add(esquerdaMinimo);
    }
	
	void Update () 
    {  
        int unhasLixadas = 0;

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

        if (Input.GetMouseButton(0) &&
            (transform.position.x > 1.4 && transform.position.y > -3.7) &&
            (transform.position.x > 1.4 && transform.position.y < -2.7) &&
            (transform.position.x < 1.8 && transform.position.y > -3.7) &&
            (transform.position.x < 1.8 && transform.position.y < -2.7))
        {            
            direitaMinimo.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 2.4 && transform.position.y > -4.3) &&
            (transform.position.x > 2.4 && transform.position.y < -3.7) &&
            (transform.position.x < 2.9 && transform.position.y > -4.3) &&
            (transform.position.x < 2.9 && transform.position.y < -3.7))
        {
            direitaAnular.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 3.7 && transform.position.y > -4.3) &&
            (transform.position.x > 3.7 && transform.position.y < -3.8) &&
            (transform.position.x < 3.9 && transform.position.y > -4.3) &&
            (transform.position.x < 3.9 && transform.position.y < -3.8))
        {
            direitaMedio.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 5.0 && transform.position.y > -4.3) &&
            (transform.position.x > 5.0 && transform.position.y < -3.8) &&
            (transform.position.x < 5.2 && transform.position.y > -4.3) &&
            (transform.position.x < 5.2 && transform.position.y < -3.8))
        {
            direitaIndicador.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 5.5 && transform.position.y > -2.4) &&
            (transform.position.x > 5.5 && transform.position.y < -2.0) &&
            (transform.position.x < 5.9 && transform.position.y > -2.4) &&
            (transform.position.x < 5.9 && transform.position.y < -2.0))
        {
            direitaPolegar.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 5.9 && transform.position.y > -2.4) &&
            (transform.position.x > 5.9 && transform.position.y < -2.0) &&
            (transform.position.x < 6.3 && transform.position.y > -2.4) &&
            (transform.position.x < 6.3 && transform.position.y < -2.0))
        {
            esquerdaPolegar.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 7.4 && transform.position.y > -3.8) &&
            (transform.position.x > 7.4 && transform.position.y < -3.4) &&
            (transform.position.x < 7.7 && transform.position.y > -3.8) &&
            (transform.position.x < 7.7 && transform.position.y < -3.4))
        {
            esquerdaIndicador.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 8.8 && transform.position.y > -3.5) &&
            (transform.position.x > 8.8 && transform.position.y < -2.9) &&
            (transform.position.x < 9.0 && transform.position.y > -3.5) &&
            (transform.position.x < 9.0 && transform.position.y < -2.9))
        {
            esquerdaMedio.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 9.5 && transform.position.y > -2.8) &&
            (transform.position.x > 9.5 && transform.position.y < -2.3) &&
            (transform.position.x < 9.8 && transform.position.y > -2.8) &&
            (transform.position.x < 9.8 && transform.position.y < -2.3))
        {
            esquerdaAnular.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > 9.8 && transform.position.y > -1.8) &&
            (transform.position.x > 9.8 && transform.position.y < -1.4) &&
            (transform.position.x < 10.1 && transform.position.y > -1.8) &&
            (transform.position.x < 10.1 && transform.position.y < -1.4))
        {
            esquerdaMinimo.SetActive(true);
        }

        foreach (var item in maos) 
        {
            if (item.activeInHierarchy)
            {
                unhasLixadas++;
            }
        }

        if (unhasLixadas == 10)
        {
            instrucao.text = "Escolha a cor e pinte as unhas.\r\nClique em \"Estou pronta!\" quando terminar de pintar as unhas.";
            gameObject.SetActive(false);
            pincel.SetActive(true);
            esmalteVermelho.gameObject.SetActive(true);
            esmalteRosa.gameObject.SetActive(true);
            esmalteRoxo.gameObject.SetActive(true);
            esmalteCoco.gameObject.SetActive(true);
            proximaFase.gameObject.SetActive(true);
        }
	}
}