using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IluminacaoMontanha : MonoBehaviour 
{
    public Color cor1 = Color.yellow;
    public Color cor2 = Color.black;
    public float duracao = 3f;

    Camera cam;

    void Start () 
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }   

    void Update()
    {
        float t = Mathf.PingPong(Time.time, duracao) / duracao;
        cam.backgroundColor = Color.Lerp(cor1, cor2, t);  
    }
}
