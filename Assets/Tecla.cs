﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tecla : MonoBehaviour
{
    private AudioSource Audio;
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        Audio.Play();
    }    
}
