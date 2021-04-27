using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    public AudioClip loop;
    public AudioSource playerAudio;
    public Animator anim;

    public void TrocaAudioLoop()
    {
        if (playerAudio.isPlaying)
        {
            playerAudio.Stop();            
            if (!playerAudio.clip.Equals(loop))
            {
                playerAudio.clip = loop;
                playerAudio.Play();
                
            }
        }
        else
        {
            playerAudio.clip = loop;
            playerAudio.Play();
        }

        anim.SetBool("isPlaying", playerAudio.isPlaying);
    }
}
