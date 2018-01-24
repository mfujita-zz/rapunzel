using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoCor : MonoBehaviour 
{
    public static Color32 cor;

    public void Vermelha()
    {
        cor = new Color32(255, 0, 0, 255);
    }

    public void Rosa()
    {
        cor = new Color32(255, 0, 255, 255);
    }

    public void Roxo()
    {
        cor = new Color32(135, 0, 255, 255);
    }

    public void Coco()
    {
        cor = new Color32(103, 52, 52, 255);
    }
}
