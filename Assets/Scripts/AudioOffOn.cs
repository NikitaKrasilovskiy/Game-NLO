using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioOffOn : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup Mixer;
    //public void MusicOffOn(bool enable)
    //{
    //    if (enable)
    //        Mixer.audioMixer.SetFloat("Music", 0);
    //    else
    //        Mixer.audioMixer.SetFloat("Music", -80);
    //}
    public void MasterVolume (float volume)
    {
        Mixer.audioMixer.SetFloat("Master", Mathf.Lerp(0, -80, volume));
    }
}
