using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField]
    AudioMixer masterAudioMixer;

    float volume;

    public void OnEnable()
    {
        masterAudioMixer.SetFloat("Master Volume", PlayerPrefs.GetFloat("Volume", 0));
        GetComponent<Slider>().value = PlayerPrefs.GetFloat("Volume");
    }

    public void SetVolume(float vol)
    {
        masterAudioMixer.SetFloat("Master Volume", vol);
        volume = vol;
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("Volume", volume);
    }
}
