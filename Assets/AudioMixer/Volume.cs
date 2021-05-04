using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public AudioMixer audioMixer;
    private Slider slider;
    public string qualVolume;

    private void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = PlayerPrefs.GetFloat(qualVolume, 0);
        audioMixer.SetFloat(qualVolume , slider.value);
    }
    public void AlterarVolume()
    {
        audioMixer.SetFloat(qualVolume, slider.value);
        PlayerPrefs.SetFloat(qualVolume, slider.value);
    }

}
