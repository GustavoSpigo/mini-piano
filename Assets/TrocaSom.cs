using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrocaSom : MonoBehaviour
{
    public AudioClip somASerTocado;
    public AudioSource[] teclas;

    public void TrocarSom()
    {
        foreach (AudioSource CadaTecla in teclas)
        {
            CadaTecla.clip = somASerTocado;
        }

        //foreach (GameObject CadaTecla in GameObject.FindGameObjectsWithTag("Teclas"))
        //{
        //    CadaTecla.GetComponent<AudioSource>().clip = somASerTocado;
        //}

        //for (int i = 0; i < teclas.Length; i++)
        //{
        //    teclas[i].clip = somASerTocado;
        //}
    }
}
