using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnVolumeChange : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;

    public void OnSliderChange()
    {
        audioSource.volume = slider.value;
        Debug.Log(slider.value);
    }

}
