﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruxa : MonoBehaviour 
{
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
}
