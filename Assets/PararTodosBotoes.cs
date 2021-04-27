using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PararTodosBotoes : MonoBehaviour
{
    public Animator[] ondas;

    public void paraTudo()
    {
        foreach (Animator onda in ondas)
        {
            onda.SetBool("isPlaying", false);
        }
    }
}
