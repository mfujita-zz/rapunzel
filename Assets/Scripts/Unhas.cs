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
            (transform.position.x > (-0.54f-.5f) && transform.position.y > (-3.35-.5f)) &&
            (transform.position.x > (-0.54f-.5f) && transform.position.y < (-3.35+.5f)) &&
            (transform.position.x < (-0.54f+.5f) && transform.position.y > (-3.35-.5f)) &&
            (transform.position.x < (-0.54f+.5f) && transform.position.y < (-3.35+.5f)))
        {            
            direitaMinimo.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (0.46f-.5f) && transform.position.y > (-3.39f-0.5f)) &&
            (transform.position.x > (0.46f-.5f) && transform.position.y < (-3.39f+0.5f)) &&
            (transform.position.x < (0.46f+.5f) && transform.position.y > (-3.39f-0.5f)) &&
            (transform.position.x < (0.46f+.5f) && transform.position.y < (-3.39f+0.5f)))
        {
            direitaAnular.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (1.64f-0.5f) && transform.position.y > (-4.3f-0.5f)) &&
            (transform.position.x > (1.64f-0.5f) && transform.position.y < (-4.3f+0.5f)) &&
            (transform.position.x < (1.64f+0.5f) && transform.position.y > (-4.3f-0.5f)) &&
            (transform.position.x < (1.64f+0.5f) && transform.position.y < (-4.3f+0.5f)))
        {
            direitaMedio.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (2.84f-0.5f) && transform.position.y > (-4f-0.5f)) &&
            (transform.position.x > (2.84f-0.5f) && transform.position.y < (-4f+0.5f)) &&
            (transform.position.x < (2.84f+0.5f) && transform.position.y > (-4f-0.5f)) &&
            (transform.position.x < (2.84f+0.5f) && transform.position.y < (-4f+0.5f)))
        {
            direitaIndicador.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (3.46f-0.5f) && transform.position.y > (-2.29-0.5f)) &&
            (transform.position.x > (3.46f-0.5f) && transform.position.y < (-2.29+0.5f)) &&
            (transform.position.x < (3.46f+0.5f) && transform.position.y > (-2.29-0.5f)) &&
            (transform.position.x < (3.46f+0.5f) && transform.position.y < (-2.29+0.5f)))
        {
            direitaPolegar.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (3.39f-0.5f) && transform.position.y > (-2.29-0.5f)) &&
            (transform.position.x > (3.39f-0.5f) && transform.position.y < (-2.29+0.5f)) &&
            (transform.position.x < (3.39f+0.5f) && transform.position.y > (-2.29-0.5f)) &&
            (transform.position.x < (3.39f+0.5f) && transform.position.y < (-2.29+0.5f)))
        {
            esquerdaPolegar.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (5.39f-0.5f) && transform.position.y > (-3.67f-0.5f)) &&
            (transform.position.x > (5.39f-0.5f) && transform.position.y < (-3.67f+0.5f)) &&
            (transform.position.x < (5.39f+0.5f) && transform.position.y > (-3.67f-0.5f)) &&
            (transform.position.x < (5.39f+0.5f) && transform.position.y < (-3.67f+0.5f)))
        {
            esquerdaIndicador.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (6.74f-0.5f) && transform.position.y > (-3.41f-0.5f)) &&
            (transform.position.x > (6.74f-0.5f) && transform.position.y < (-3.41f+0.5f)) &&
            (transform.position.x < (6.74f+0.5f) && transform.position.y > (-3.41f-0.5f)) &&
            (transform.position.x < (6.74f+0.5f) && transform.position.y < (-3.41f+0.5f)))
        {
            esquerdaMedio.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (7.5f-0.5f) && transform.position.y > (-2.74-0.5f)) &&
            (transform.position.x > (7.5f-0.5f) && transform.position.y < (-2.74+0.5f)) &&
            (transform.position.x < (7.5f+0.5f) && transform.position.y > (-2.74-0.5f)) &&
            (transform.position.x < (7.5f+0.5f) && transform.position.y < (-2.74+0.5f)))
        {
            esquerdaAnular.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0) &&
            (transform.position.x > (7.7f-0.5f) && transform.position.y > (-1.7f-0.5f)) &&
            (transform.position.x > (7.7f-0.5f) && transform.position.y < (-1.7f+0.5f)) &&
            (transform.position.x < (7.7f+0.5f) && transform.position.y > (-1.7f-0.5f)) &&
            (transform.position.x < (7.7f+0.5f) && transform.position.y < (-1.7f+0.5f)))
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